using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WatsonTcp;
using static Client_V3.Variabili;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client_V3
{
    internal class ClientsConnection
    {
        public static string argomento_Invio = "";
        public static string argomento_Ricevuto = "";
        public static bool client_Connesso = false;

        internal class TestClient
        {
            public static string _ServerIp = "127.1"; // adly.xed.im 185.229.236.183
            //public static string _ServerIp = "185.229.236.183"; // adly.xed.im 185.229.236.183
            private static int _ServerPort = 8443;
            private static bool _Ssl = true;
            private static string _CertFile = "";
            private static string _CertPass = "Password1";
            private static bool _DebugMessages = true;
            private static bool _AcceptInvalidCerts = false;
            private static bool _MutualAuth = false;
            private static WatsonTcpClient _Client = null;
            private static string _PresharedKey = null;

            public static Task ClientSend(string argomento)
            {
                return Task.Run(() => //Crea un task e gli assegna un blocco istruzioni da eseguire.
                {
                    if (!_Client.Send(Encoding.UTF8.GetBytes(argomento))) Console.WriteLine("Failed");
                    Thread.Sleep(1500);
                });
            }
            public static Task InitializeClient() {
                return Task.Run(async () => //Crea un task e gli assegna un blocco istruzioni da eseguire.
                {
                    bool runForever = true;
                    bool success;

                    Console.WriteLine("Client partito");
                    Console.WriteLine($"Use SSL: {_Ssl}");

                    if (_Ssl)
                    {
                        bool supplyCert = true;
                        Console.WriteLine($"Supply SSL certificate: {supplyCert}");

                        if (supplyCert)
                        {
                            _CertFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $@"/Documents/Client.pfx";
                            _CertPass = "Password1";
                        }

                        _AcceptInvalidCerts = true;
                        _MutualAuth = true;
                        Console.WriteLine($"Accept invalid certs: {_AcceptInvalidCerts}");
                        Console.WriteLine($"Mutually authenticate: {_MutualAuth}");
                    }
                   await ConnectClient();
                });
            }
            public static Task ConnectClient()
            {
                return Task.Run(() => //Crea un task e gli assegna un blocco istruzioni da eseguire.
                {
                    if (_Client != null) _Client.Dispose();
                    if (!_Ssl) _Client = new WatsonTcpClient(_ServerIp, _ServerPort);
                    else
                    {
                        _Client = new WatsonTcpClient(_ServerIp, _ServerPort, _CertFile, _CertPass);
                        _Client.Settings.AcceptInvalidCertificates = _AcceptInvalidCerts;
                        _Client.Settings.MutuallyAuthenticate = _MutualAuth;
                    }
                    _Client.Events.AuthenticationFailure += AuthenticationFailure;
                    _Client.Events.AuthenticationSucceeded += AuthenticationSucceeded;
                    _Client.Events.ServerConnected += ServerConnected;
                    _Client.Events.ServerDisconnected += ServerDisconnected;
                    _Client.Events.MessageReceived += MessageReceived;
                    _Client.Events.ExceptionEncountered += ExceptionEncountered; //???

                    _Client.Callbacks.SyncRequestReceived = SyncRequestReceived;
                    _Client.Callbacks.AuthenticationRequested = AuthenticationRequested;

                    // _Client.Settings.IdleServerTimeoutMs = 5000;
                    _Client.Settings.DebugMessages = _DebugMessages;
                    _Client.Settings.Logger = Logger;
                    _Client.Settings.NoDelay = true;

                    _Client.Keepalive.EnableTcpKeepAlives = true;
                    _Client.Keepalive.TcpKeepAliveInterval = 1;
                    _Client.Keepalive.TcpKeepAliveTime = 1;
                    _Client.Keepalive.TcpKeepAliveRetryCount = 3;

                    _Client.Connect();
                    client_Connesso = true;
                });
            }
            private static void ExceptionEncountered(object sender, ExceptionEventArgs e)
            {
                Console.WriteLine("*** Exception ***");
                Console.WriteLine(e.ToString());
            }
            private static string AuthenticationRequested()
            {
                // return "0000000000000000";
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Server requests authentication");
                Console.WriteLine("Press ENTER and THEN enter your preshared key");
                if (String.IsNullOrEmpty(_PresharedKey)) _PresharedKey = _CertPass;
                return _PresharedKey;
            }
            public static Task Send_Server(string argomento)
            {
                return Task.Run(() => //Crea un task e gli assegna un blocco istruzioni da eseguire.
                {
                    if (!_Client.Send(Encoding.UTF8.GetBytes(argomento))) Console.WriteLine("Failed");
                    Thread.Sleep(5);
                });
            }
            private static void AuthenticationSucceeded(object sender, EventArgs args)
            {
                Console.WriteLine("Authentication succeeded");
            }
            private static void AuthenticationFailure(object sender, EventArgs args)
            {
                Console.WriteLine("Authentication failed");
            }
            private static void MessageReceived(object sender, MessageReceivedEventArgs args)
            {
                Console.Write("Message from server: ");
                if (args.Data == null)
                {
                    Console.WriteLine("[null]");
                    return;
                }
                string messaggio_Ricevuto = Encoding.UTF8.GetString(args.Data); // Ottenimento Risposta dal server

                Console.WriteLine("Messaggio Ricevuto");
                Console.WriteLine("Ricevuto: " + messaggio_Ricevuto);

                var msgArgs = messaggio_Ricevuto.Split('|');
                
                if (msgArgs.Length < 0)
                { Console.WriteLine("[Errore|ServerConnection] >> needed 1 args"); return; }

                switch (msgArgs[0])
                {
                    case "simulazione": Variabili.queue_Simulate_Command.Enqueue(messaggio_Ricevuto); break;
                    case "plotSwap": 
                        Variabili.plot_Disponibile = msgArgs[2];
                        if (msgArgs[3] == "")
                            Variabili.plot_Noleggiati = "0";
                        else
                            Variabili.plot_Noleggiati = msgArgs[3];
                        Variabili.queue_Payment_Command.Enqueue(messaggio_Ricevuto);
                        break;
                    case "home_fee":
                        Variabili.fee_A = msgArgs[1];
                        Variabili.fee_B = msgArgs[2];
                        Variabili.fee_C = msgArgs[3];
                        break;
                    case "balance_P_Update":
                        Variabili.Bilanci.Protocol.XCH               = msgArgs[1];
                        Variabili.Bilanci.Protocol.ATOM              = msgArgs[2];
                        Variabili.Bilanci.Protocol.CRO               = msgArgs[3];
                        Variabili.Bilanci.Protocol.LUNA              = msgArgs[4];
                        Variabili.Bilanci.Protocol.TIA               = msgArgs[5];
                        Variabili.Bilanci.Protocol.USDT              = msgArgs[6];
                        Variabili.Bilanci.Protocol.USDC              = msgArgs[7];
                        Variabili.Bilanci.Protocol.axlUSDC           = msgArgs[8];
                        Variabili.Bilanci.Protocol.XDLS              = msgArgs[9];
                        Variabili.Bilanci.Protocol.XUSDT             = msgArgs[10];

                        Variabili.xch_Prelevabili   = Convert.ToDouble(msgArgs[11]).ToString("0.0000000000");
                        Variabili.xch_Pending       = Convert.ToDouble(msgArgs[12]).ToString("0.0000000000");
                        Variabili.chia_prelevati    = msgArgs[13];
                        Variabili.Credito_Rimasto   = msgArgs[14];
                        Variabili.giorni_Rimasti    = msgArgs[15];
                        break;
                    case "balance_Swap_Update":
                        Variabili.Bilanci.Protocol_Swap.XCH = msgArgs[1];
                        Variabili.Bilanci.Protocol_Swap.ATOM = msgArgs[2];
                        Variabili.Bilanci.Protocol_Swap.CRO = msgArgs[3];
                        Variabili.Bilanci.Protocol_Swap.LUNA = msgArgs[4];
                        Variabili.Bilanci.Protocol_Swap.TIA = msgArgs[5];
                        Variabili.Bilanci.Protocol_Swap.USDT = msgArgs[6];
                        Variabili.Bilanci.Protocol_Swap.USDC = msgArgs[7];
                        Variabili.Bilanci.Protocol_Swap.axlUSDC = msgArgs[8];
                        Variabili.Bilanci.Protocol_Swap.XDLS = msgArgs[9];
                        Variabili.Bilanci.Protocol_Swap.XUSDT = msgArgs[10];
                        Variabili.Bilanci.Protocol_Swap.DMP = msgArgs[11];
                        break;
                    case "timerUSDT":
                        Variabili.status_Pagamento = msgArgs[1];
                        Variabili.importo_USDT = msgArgs[2].ToString();
                        Variabili.queue_Payment_Command.Enqueue(messaggio_Ricevuto);
                        break;
                    case "ID":
                        Variabili.id_Client = msgArgs[1];
                        break;
                    case "rendita": // Imposta true o false a seconda di se corrisponde o meno
                        Variabili.Rendita_Base_A = Convert.ToDouble(msgArgs[1]);
                        Variabili.Rendita_Base_B = Convert.ToDouble(msgArgs[2]);
                        Variabili.Rendita_Base_C = Convert.ToDouble(msgArgs[3]);
                        Variabili.Rendita_Base_D = Convert.ToDouble(msgArgs[4]);
                        Variabili.Rendita_Base_E = Convert.ToDouble(msgArgs[5]);
                        break;
                    case "bonus": // Imposta true o false a seconda di se corrisponde o meno
                        Variabili.bonus_Deposito = Convert.ToDouble(msgArgs[1]);
                        Variabili.bonus_Innvito_Ref = Convert.ToDouble(msgArgs[2]);
                        Variabili.bonus_Invitato_Ref  = Convert.ToDouble(msgArgs[3]);
                        break;
                    case "validate": // Imposta true o false a seconda di se corrisponde o meno
                        Variabili.seedPhrase_Approved = Convert.ToBoolean(msgArgs[1]);
                        break;
                    case "Protocollo": // Imposta true o false a seconda di se corrisponde o meno
                        Variabili.totale_Utenti = msgArgs[1];
                        Variabili.totale_Deposito_Euro = msgArgs[2];
                        Variabili.totale_Deposito_USDT = msgArgs[3];
                        Variabili.totale_Bonus_Pagato = msgArgs[4];
                        Variabili.Prezzi.APR.XDLS = msgArgs[5];
                        Variabili.Prezzi.APR.XUSDT = msgArgs[6];
                        Variabili.Prezzi.Unlock_Days.XDLS = msgArgs[7];
                        Variabili.Prezzi.Unlock_Days.XUSDT = msgArgs[8];
                        break;
                    case "Login": // Imposta true o false a seconda di se corrisponde o meno
                        if (msgArgs[1] == "Approved") Variabili.login_Approved = true;
                        else Variabili.login_Approved = false;
                        break;
                    case "update_user_balance": // Aggiorna il bilancio cripto dell'utente
                        Variabili.Bilanci.Swap.XCH          = msgArgs[1];
                        Variabili.Bilanci.Swap.ATOM         = msgArgs[2];
                        Variabili.Bilanci.Swap.CRO          = msgArgs[3];
                        Variabili.Bilanci.Swap.LUNA         = msgArgs[4];
                        Variabili.Bilanci.Swap.TIA          = msgArgs[5];
                        Variabili.Bilanci.Swap.USDT         = msgArgs[6];
                        Variabili.Bilanci.Swap.USDC         = msgArgs[7];
                        Variabili.Bilanci.Swap.axlUSDC      = msgArgs[8];
                        Variabili.Bilanci.Swap.XDLS         = msgArgs[9];
                        Variabili.Bilanci.Swap.XUSDT        = msgArgs[10];

                        Variabili.Bilanci.Staking.XDLS      = msgArgs[11];
                        Variabili.Bilanci.Staking.XUSDT     = msgArgs[12];
                        Variabili.Bilanci.Staking.ATOM      = msgArgs[13];
                        Variabili.Bilanci.Staking.CRO       = msgArgs[14];
                        Variabili.Bilanci.Staking.LUNA      = msgArgs[15];
                        Variabili.Bilanci.Staking.USDT      = msgArgs[16];
                        Variabili.Bilanci.Staking.USDC      = msgArgs[17];
                        Variabili.Bilanci.Staking.axlUSDC   = msgArgs[18];

                        Variabili.Bilanci.Swap_Pending.XCH  = msgArgs[19];
                        break;
                    case "update_coin_price": // Aggiorna i prezzi delle cripto dell'utente
                        Variabili.Prezzi.Protocol.XCH        = msgArgs[1];
                        Variabili.Prezzi.Protocol.ATOM       = msgArgs[2];
                        Variabili.Prezzi.Protocol.CRO        = msgArgs[3];
                        Variabili.Prezzi.Protocol.LUNA       = msgArgs[4];
                        Variabili.Prezzi.Protocol.TIA        = msgArgs[5];
                        Variabili.Prezzi.Protocol.USDT       = msgArgs[6];
                        Variabili.Prezzi.Protocol.USDC       = msgArgs[7];
                        Variabili.Prezzi.Protocol.axlUSDC    = msgArgs[8];
                        Variabili.Prezzi.Protocol.XDLS       = msgArgs[9];
                        Variabili.Prezzi.Protocol.XUSDT      = msgArgs[10];
                        Variabili.slippage                   = msgArgs[11];
                        Variabili.protocol_Fee               = msgArgs[12];
                        break;
                    case "swap_coin_value":
                        Variabili.swap_Result = msgArgs[1];
                        break;
                    case "unstake":
                        Variabili.unstake_TRansaction.Clear();
                        var transazione = new List<string[]>();

                        var dati = msgArgs[1].Split('-');
                        int a = Convert.ToInt32(dati[0]); //Numero transazioni
                        int b = 0;

                        for (int i = 0; i < a; i++)
                        {
                            if (i > 0)
                                b += Convert.ToInt32(dati[1]);
                            var tx_Data = new string[] { (i + 1).ToString(), dati[2 + b], dati[3 + b], dati[4 + b], dati[5 + b], dati[6 + b], dati[7 + b], dati[8 + b] };
                            transazione.Add(tx_Data);
                            Variabili.unstake_TRansaction.Add(tx_Data);
                        }
                        break;
                    case "cloudMining":
                        Variabili.cloudMining_TRansaction.Clear();
                        var transazione1 = new List<string[]>();

                        var data = msgArgs[1].Split('-');
                        int a1 = Convert.ToInt32(data[0]); //Numero transazioni
                        int b1 = 0;

                        for (int i = 0; i < a1; i++)
                        {
                            if (i > 0)
                                b1 += Convert.ToInt32(data[1]);
                            var tx_Data = new string[] { (i + 1).ToString(), data[3 + b1], data[6 + b1], data[5 + b1], data[4 + b1], data[2 + b1] };
                            transazione1.Add(tx_Data);
                            Variabili.cloudMining_TRansaction.Add(tx_Data);
                        }
                        break;
                    case "swap":
                        Variabili.swap_TRansaction.Clear();
                        var transazione2 = new List<string[]>();

                        var data2 = msgArgs[1].Split('-');
                        int a2 = Convert.ToInt32(data2[0]); //Numero transazioni
                        int b2 = 0;

                        for (int i = 0; i < a2; i++)
                        {
                            if (i > 0)
                                b2 += Convert.ToInt32(data2[1]);
                            var tx_Data = new string[] { (i + 1).ToString(), data2[4 + b2], data2[3 + b2], data2[5 + b2], data2[7 + b2], data2[6 + b2], data2[8 + b2], data2[2 + b2], data2[9 + b2] };
                            transazione2.Add(tx_Data);
                            Variabili.swap_TRansaction.Add(tx_Data);
                        }
                        break;

                    default: Console.WriteLine($"[Errore] >> [{messaggio_Ricevuto}] Comando non riconosciuto"); break;
                }

                var comando = msgArgs[0];
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Comando:        {comando}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");

                switch (comando)
                {
                    case "plotSwap": Message_Recived_PlotSwap(msgArgs); break;      // Risposta prezzo per plot
                    case "statusPayment": Message_Recived_StatusPayment(msgArgs); break; // Risposta timer payment usdt
                }
            }

            private static void Message_Recived_PlotSwap(string[] msgArgs)
            {
                argomento_Ricevuto = msgArgs[1];  //Assegnazione a variabile (Vecchio metodo comunicazione)
            }
            private static void Message_Recived_StatusPayment(string[] msgArgs)
            {
                argomento_Ricevuto = msgArgs[1];  //Assegnazione a variabile (Vecchio metodo comunicazione)
            }

            private static SyncResponse SyncRequestReceived(SyncRequest req)
            {
                Console.Write("Message received from server: ");
                if (req.Data != null) Console.WriteLine(Encoding.UTF8.GetString(req.Data));
                else Console.WriteLine("[null]");

                // Uncomment to test timeout
                // Task.Delay(10000).Wait();
                return new SyncResponse(req, "Here is your response!");
            }
            private static void ServerConnected(object sender, ConnectionEventArgs args)
            {
                Console.WriteLine("Server connected"); // Controlla se c'è una connessione col server
                client_Connesso = true;
            }
            private static void ServerDisconnected(object sender, DisconnectionEventArgs args)
            {
                Console.WriteLine("Server disconnected: " + args.Reason.ToString());
                client_Connesso = false;
            }
            private static void Logger(Severity sev, string msg)
            {
                Console.WriteLine("[" + sev.ToString().PadRight(9) + "] " + msg);
            }
            public static async Task Disconnetti()
            {
                if (client_Connesso == true)
                {
                    _Client.Disconnect();
                    client_Connesso = false;
                }
            }

            public static async Task Connessione() {
                if (client_Connesso == false)
                {
                    await InitializeClient();
                    await Send_Server($"auth|{Variabili.wallet}");
                    client_Connesso = true;
                }
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client_V3
{
    internal class Variabili
    {
        public static Queue<string> queue_Payment_Command { get; } = new Queue<string>(); //Code
        public static Queue<string> queue_Simulate_Command { get; } = new Queue<string>();

        public static List<string[]> unstake_TRansaction = new List<string[]>();
        public static List<string[]> cloudMining_TRansaction = new List<string[]>();
        public static List<string[]> swap_TRansaction = new List<string[]>();

        public static List<string> coins = new List<string> { "CHIA", "ATOM", "CRO", "LUNA", "TIA", "USDT", "USDC", "axlUSDC", "XDLS", "XUSDT" };

        public class Bilanci
        {
            public string XCH { get; set; }
            public string ATOM { get; set; }
            public string CRO { get; set; }
            public string LUNA { get; set; }
            public string TIA { get; set; }
            public string USDT { get; set; }
            public string USDC { get; set; }
            public string axlUSDC { get; set; }
            public string XDLS { get; set; }
            public string XUSDT { get; set; }
            public string DMP { get; set; }

            public static Bilanci Swap = new Bilanci //Bilancio utente
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Bilanci Swap_Pending = new Bilanci //Bilancio utente
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Bilanci Protocol = new Bilanci //Coin disponibili nel bilancio del protocollo
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Bilanci Protocol_Swap = new Bilanci //Coin disponibili x lo Swap
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Bilanci Staking = new Bilanci //Coin in staking messi dall'utente
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Bilanci Unstake = new Bilanci //Coin in Unstake
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
        }
        public class Prezzi : Bilanci
        {
            public static Prezzi Protocol = new Prezzi
            {
                XCH = "0",
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Prezzi APR = new Prezzi
            {
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
            public static Prezzi Unlock_Days = new Prezzi
            {
                ATOM = "0",
                CRO = "0",
                LUNA = "0",
                TIA = "0",
                USDT = "0",
                USDC = "0",
                axlUSDC = "0",
                XDLS = "0",
                XUSDT = "0",
                DMP = "0"
            };
        }



        // -------------------- Fee Xch -----------------------
        public static string fee_A = "Null";
        public static string fee_B = "Null";
        public static string fee_C = "Null";

        // -------------------- Slippage Swap -----------------------
        public static string slippage = "0";
        public static string protocol_Fee = "0";

        // -------------------- Rendita -----------------------
        public static double Rendita_Base_A = 0.00;
        public static double Rendita_Base_B = 0.00;
        public static double Rendita_Base_C = 0.00;
        public static double Rendita_Base_D = 0.00;
        public static double Rendita_Base_E = 0.00;
        public static double bonus_Deposito = 0.00;
        public static double bonus_Innvito_Ref = 0.00;
        public static double bonus_Invitato_Ref = 0.00;

        public static double xdls_Rendita = 0;
        public static double xusdt_Rendita = 0;

        // -------------------- xxx -----------------------

        public static string xch_Prelevabili        = "0";
        public static string xch_Pending            = "0";
        public static string chia_prelevati         = "0";
        public static string Credito_Rimasto        = "0";
        public static string totale_Utenti          = "0";
        public static string totale_Deposito_Euro   = "0";
        public static string totale_Deposito_USDT   = "0";
        public static string totale_Bonus_Pagato    = "0";
        public static string giorni_Rimasti         = "0";

        public static string status_Pagamento       = "Stato pagamento: Nessuno";
        public static string id_Client              = "not connected";
        public static string importo_USDT           = "";
        public static string plot_Euro              = "0";
        public static string swap_Result    = "0";


        // -------------------- Protocol Login -----------------------
        public static bool login_Stato          = false; // Se il pulsante login è stato premuto
        public static bool login_Approved       = false; // Se l'autenticazione dei dati è avvenuta ed è stata confermata
        public static bool seedPhrase_Approved  = false; // Se il seedPhrase corrisponde abilita il reset della password
        public static bool loop_Command_Payment = false;

        // -------------------- User Data Client -----------------------
        public static string invito_Referal         = "Null";
        public static string wallet                 = "Null";
        public static string password               = "Null";
        public static string seed                   = "Null";
        public static string pagamento_Somma_USDT   = "Null";
        public static string numero_Plot            = "Null";
        public static string wallet_USDT            = "Null";
        public static string chain                  = "Null";
        public static string plot_Noleggiati        = "Plot Noleggiati: 0";
        public static string plot_Disponibile       = "Plot Disponibili: 0";

        // -------------------- User Data Client -----------------------
        public static double eur_usd = 0;
        public static double usd_usdt = 0;

        public static string percorso_database = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\A_Client\Transaction\";
        public static string test_Percorso_Cartella = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\A_Client\";
        public static string test_Percorso_Transazioni = test_Percorso_Cartella + @"Transaction";

        public static void Impostazioni()
        {
            if(Client_V3.Properties.Settings.Default.Salvataggio == false)
            {
                // Assegnazione valori default se in presenza di un nuovo utente
                invito_Referal = "Null";
                wallet = "Null";
                // email = "email@test.com"; // Deprecato
                Client_V3.Properties.Settings.Default.Salvataggio = false;
                Console.WriteLine("Nuovo utente, nessuna impostazione da caricare");
            }
            else
            {
                //Caricamento impostazioni se presente qualcosa in appdata

                wallet           =   Client_V3.Properties.Settings.Default.Wallet_Chia;
                invito_Referal   =   Client_V3.Properties.Settings.Default.Referal_Code;

                Client_V3.Properties.Settings.Default.Salvataggio = true;
                Console.WriteLine("Caricamento impostazioni dati utente...");
            }
        }

        public static int conta_numero_elementi()
        {
            if (System.IO.Directory.Exists(test_Percorso_Cartella));
                System.IO.Directory.CreateDirectory(test_Percorso_Cartella);
            if (System.IO.Directory.Exists(test_Percorso_Transazioni)) ;
            System.IO.Directory.CreateDirectory(test_Percorso_Transazioni);


            return System.IO.Directory.GetFiles(percorso_database).Length;
        }//Conta il numero di elementi all'interno della cartella database, restituendo un valore numerico

        public static string[] carica_contenuto_elementi()
        {
            string[] elementi_trovati = System.IO.Directory.GetFiles(percorso_database);
            return elementi_trovati;
        }

    }
}

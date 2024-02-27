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

        public static bool loop_Command_Payment = false;

        public static string invito_Referal         = "Null";
        public static string wallet                 = "Null";
        public static string pagamento_Somma_USDT   = "Null";
        public static string numero_Plot            = "Null";
        public static string username               = "PincoPallino";
        public static string email                  = "email@test.com";
        public static string wallet_USDT            = "Null";
        public static string chain                  = "Null";

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
                username = "PincoPallino";
                email = "email@test.com";
                Client_V3.Properties.Settings.Default.Salvataggio = false;
                Console.WriteLine("Nuovo utente, nessuna impostazione da caricare");
            }
            else
            {
                //Caricamento impostazioni se presente qualcosa in appdata
                Client_V3.Properties.Settings.Default.Salvataggio = true;

                wallet           =   Client_V3.Properties.Settings.Default.Wallet_Chia;
                invito_Referal   =   Client_V3.Properties.Settings.Default.Referal_Code;
                email            =   Client_V3.Properties.Settings.Default.Email;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Client_V3
{
    internal class Certificati
    {
        public static void Crea_Certificato()
        {
            // Define certificate parameters
            string subjectName = Environment.MachineName; //Ottine il nome della macchina (hostname)
            int expirationYears = 1;

            // Create a certificate request
            using (var rsa = RSA.Create(4096))
            {
                var request = new CertificateRequest($"CN={subjectName}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                // Set certificate extensions (optional)
                request.CertificateExtensions.Add(
                    new X509BasicConstraintsExtension(false, false, 0, true));

                // Create self-signed certificate
                var certificate = request.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(expirationYears));

                // Save the certificate to a .pfx file
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $@"/Documents/Client.pfx";
                byte[] certData = certificate.Export(X509ContentType.Pfx, "Password1"); // Provide a password to protect the private key
                System.IO.File.WriteAllBytes(filePath, certData);

                Console.WriteLine("Self-signed certificate generated successfully and saved to: " + filePath);
            }
        }
    }
}

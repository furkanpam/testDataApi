using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Core.Utilties.Encryption
{
    public class RsaEncrypion
    {
        //private static readonly string privateKey;
        //private static readonly string modulus = "riB+BYN3/68jrJ5VEL+zIBA7qrYA6S0srDexkIATVMgdRZerwLW8P/US0ODFS2uJmvcXecBJCFU258YOeo1FOQf2lLK8YsskCSyxlESmDeMyafLWCLNRJ5vSEik4IPz3MhsC8/vjHB+NeVwQWqhjBCq1AhTgaVTeNeAY+G50WNU=";
        //private static readonly string publicExponent = "AQAB";
        //private static string xmlKey = "<RSAKeyValue><Modulus>myORR6adiFbecuNPRFUQDQR2yZSlQVDtwO00y9wOF+Krqkuzno7TwjUzKWETxOrHu/TKZpb/fxRMujCyapThZjItCdTlBSc75uPrHqwrI5Dx9sjxfRYPEdtZhiF0fo/tANVgpeWxtgblZKIEspNmBA8K+xMUf+QF/xvxje9DL7+oziCCbYBUDavXR3eq+Jrp6uS4P7guc2KsQGbekevmL/N1ag0TbzTzrlm+zwK8RsQj3aSnnwIRTpSqWbu/4rGP5C5EJt1fVGhZnS/DAI/ixJ3JWB5VzhUVmV2BgTbOIr8PC1RCyLFSc/H2Kd3Nu0KybueCwQ4Vh9U/e0GA8E3G3w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        //private static readonly RSAEncryptionPadding padding = RSAEncryptionPadding.Pkcs1;


        public static string Encrypt(string data, string xmlKeyPath)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                using (TextReader textReader = new StreamReader(xmlKeyPath))
                {
                    var xml = textReader.ReadToEnd();
                    rsa.FromXmlString(xml);
                    byte[] byteData = Encoding.UTF8.GetBytes(data);
                    var resArr = rsa.Encrypt(byteData, RSAEncryptionPadding.Pkcs1);
                    return Convert.ToBase64String(resArr);
                }
            }
        }

        public static string Decrypt(string text, string xmlKeyPath)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                using (TextReader textReader = new StreamReader(xmlKeyPath))
                {
                    var xml = textReader.ReadToEnd();
                    rsa.FromXmlString(xml);
                    var dataArr = Convert.FromBase64String(text);
                    byte[] resArr = rsa.Decrypt(dataArr, RSAEncryptionPadding.Pkcs1);
                    return Encoding.UTF8.GetString(resArr);
                }
            }
        }

        //public static string Encrypt(string text, string rsaPamPath)
        //{
        //    using (var cert = new X509Certificate2(fileName: rsaPamPath))
        //    {
        //        using (var rsa = cert.GetRSAPublicKey())
        //        {
        //            var dataArr = UTF8Encoding.UTF8.GetBytes(text);
        //            byte[] resArr = rsa.Encrypt(dataArr, RSAEncryptionPadding.Pkcs1);
        //            return Convert.ToBase64String(resArr);
        //        }
        //    }
        //}

        //static string Decrypt(byte[] data, string privateKey)
        //{
        //    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        //    {
        //        rsa.FromXmlString(privateKey);
        //        byte[] decryptedData = rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
        //        return Encoding.UTF8.GetString(decryptedData);
        //    }
        //}

        //public static string EncryptWithXml(string text, string xmlKeyPath)
        //{
        //    using (var rsa = new RSACryptoServiceProvider())
        //    {
        //        using (TextReader textReader = new StreamReader(xmlKeyPath))
        //        {
        //            var xml = textReader.ReadToEnd();
        //            rsa.FromXmlString(xml);
        //            var dataArr = UnicodeEncoding.Unicode.GetBytes(text);
        //            byte[] resArr = rsa.Encrypt(dataArr, RSAEncryptionPadding.Pkcs1);
        //            return Convert.ToBase64String(resArr);
        //        }
        //    }
        //}

        //public static string EncryptWithXml(string text)
        //{
        //    using (var rsa = new RSACryptoServiceProvider())
        //    {
        //        byte[] modulusBytes = GetModulusBytes();
        //        byte[] publicExponentBytes = GetExponentBytes();
        //        rsa.ImportParameters(new RSAParameters
        //        {
        //            Exponent = publicExponentBytes,
        //            Modulus = modulusBytes
        //        });
        //        var dataArr = UnicodeEncoding.Unicode.GetBytes(text);
        //        byte[] resArr = rsa.Encrypt(dataArr, RSAEncryptionPadding.Pkcs1);
        //        return Convert.ToBase64String(resArr);
        //    }
        //}

        //public static string Encrypt(string text, X509Certificate2 cert)
        //{
        //    using (var rsa = cert.GetRSAPublicKey())
        //    {
        //        var dataArr = UTF8Encoding.UTF8.GetBytes(text);
        //        byte[] resArr = rsa.Encrypt(dataArr, RSAEncryptionPadding.Pkcs1);
        //        return Convert.ToBase64String(resArr);
        //    }
        //}
        //private static string DecryptWithXmlNew(string encryptedText, string xmlKeyPath)
        //{
        //    using (var rsa = new RSACryptoServiceProvider())
        //    {
        //        // RSA anahtarını dosyadan oku
        //        using (TextReader textReader = new StreamReader(xmlKeyPath))
        //        {
        //            rsa.FromXmlString(textReader.ReadToEnd());
        //        }

        //        // Şifrelenmiş veriyi byte dizisine çevir
        //        byte[] encryptedData = Convert.FromBase64String(encryptedText);

        //        // Veriyi çöz
        //        byte[] decryptedData = rsa.Decrypt(encryptedData, true);

        //        // Çözülen veriyi Unicode stringe çevir
        //        string decryptedText = UnicodeEncoding.Unicode.GetString(decryptedData);

        //        return decryptedText;
        //    }
        //}

        //public static string Decrypt(string text, string rsaPamPath)
        //{
        //    try
        //    {
        //        using (var cert = new X509Certificate2(rsaPamPath))
        //        {
        //            byte[] resArr;
        //            using (var rsa = cert.GetRSAPublicKey())
        //            {
        //                var dataArr = UTF8Encoding.UTF8.GetBytes(text);
        //                resArr = rsa.Decrypt(dataArr, RSAEncryptionPadding.Pkcs1);
        //                return Convert.ToBase64String(resArr);
        //            }
        //        }
        //    }
        //    catch (Exception exp)
        //    {

        //        throw;
        //    }
        //}


        //public static void ExportModulus(string path)
        //{
        //    try
        //    {

        //        // Sertifika yolu ve şifresi
        //        //string certPassword = "bViNpnLRRbYROpSoqGJnesfvXz";

        //        // Sertifika yüklemesi
        //        X509Certificate2 certificate = new X509Certificate2(path);
        //        // Genel anahtar (public key) ve exponenti alma
        //        RSA rsa = certificate.GetRSAPublicKey();
        //        RSA privateKEy = certificate.GetRSAPrivateKey();
        //        RSAParameters rsaParams = rsa.ExportParameters(false); // false ile genel anahtar alınır

        //        byte[] modulus = rsaParams.Modulus; // Modulus (n)
        //        byte[] exponent = rsaParams.Exponent; // Exponent (e)

        //        // Modulus ve Exponent'i kullanma
        //        var modulusInfo = Convert.ToBase64String(modulus);
        //        var exponentInfo = Convert.ToBase64String(exponent);

        //        // RSA nesnesini kapat
        //        rsa.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Hata: " + ex.Message);
        //    }
        //}

        static byte[] HexStringToByteArray(string hex)
        {
            hex = hex.Replace(":", "").Replace(" ", ""); // Gereksiz karakterleri kaldırın
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static Tuple<string, string> CreateKey()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Genel anahtarı al
                string publicKey = rsa.ToXmlString(false);
                Console.WriteLine("Public Key:\n" + publicKey);

                // Özel anahtarı al
                string privateKey = rsa.ToXmlString(true);
                Console.WriteLine("\nPrivate Key:\n" + privateKey);
                return Tuple.Create(publicKey, privateKey);
            }
        }
    }
}

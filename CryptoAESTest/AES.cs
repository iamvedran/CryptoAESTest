using System;
using System.Security.Cryptography;
using System.Text;

namespace AESEncrtyption
{
    public static class AES
    {
        // koristi Advanced encryption standard symmetric
        private static AesManaged myAes = new AesManaged();


        //initialization vector (IV) 16 bytes
        private const string initalisationVector = "L9qIQK4DqkmiciqM";

        // salt bytes barem 8 bytes
        private static readonly byte[] saltBytes = new byte[] { 101, 20, 34, 43, 58, 63, 78, 82 };

        /// <summary>
        /// Kriptira string
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Kriptirani string u hexadecimalnom formatu</returns>
        public static String Encrypt(string data, string password)
        {
            byte[] dataByte = Encoding.UTF8.GetBytes(data);

            //mora biti 16 bytes
            byte[] passwordByte = Encoding.ASCII.GetBytes(password);

            //postavljamo parametre AES enkripcije
            SetEncryptionParameters(passwordByte);

            // Create a encryption object to perform the stream transform.
            ICryptoTransform encryptor = myAes.CreateEncryptor();

            return ByteArrayToHexString(encryptor.TransformFinalBlock(dataByte, 0, dataByte.Length));
        }

        /// <summary>
        /// Dekriptira string
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Dekriptirani tekst</returns>
        public static String Decrypt(string data, string password)
        {
            byte[] dataByte = HexStringToByteArray(data);

            //mora biti 16 bytes
            byte[] passwordByte = Encoding.ASCII.GetBytes(password);

            //postavljamo parametre AES enkripcije
            SetEncryptionParameters(passwordByte);

            ICryptoTransform decryptor = myAes.CreateDecryptor();

            byte[] rez = null;
            try
            {
                rez = decryptor.TransformFinalBlock(dataByte, 0, dataByte.Length);
            }
            catch 
            {
                return "Došlo je do greške kod dekriptiranja!";
            }
            return Encoding.UTF8.GetString(rez, 0, rez.Length);
        }

        /// <summary>
        /// Postavljanej parametar AES enkripcije/dekripcije.
        /// Za ovaj primjer je samo lozinka konfigurabilna iz aplikacije
        /// </summary>
        /// <param name="passwordByte">lozinka</param>
        private static void SetEncryptionParameters(byte[] passwordByte)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initalisationVector);

            // kripto ključ se generira na osnovu 1000 iteracija algoritma za miksanje lozinke i salt byteova 
            var key = new Rfc2898DeriveBytes(passwordByte, saltBytes, 1000);

            myAes.Mode = CipherMode.CBC; // cipher block chaining algoritam 
            myAes.KeySize = 256;         // 256 bitni ključ
            myAes.BlockSize = 128;
            myAes.IV = initVectorBytes;
            myAes.Padding = PaddingMode.PKCS7;
            myAes.Key = key.GetBytes(myAes.KeySize / 8);
        }

        private static byte[] HexStringToByteArray(String hexString)
        {
            try
            {
                int bytesCount = (hexString.Length) / 2;
                byte[] bytes = new byte[bytesCount];
                for (int i = 0; i < bytesCount; ++i)
                {
                    bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                }
                return bytes;
            }
            catch
            {
                throw;
            }
        }

        private static string ByteArrayToHexString(byte[] byteArray)
        {
            StringBuilder hex = new StringBuilder(byteArray.Length * 2);
            foreach (byte b in byteArray)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString().ToUpper();
        }
    }
}

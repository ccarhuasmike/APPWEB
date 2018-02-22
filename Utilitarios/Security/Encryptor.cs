using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Utilitarios.Security
{
    public class Encryptor
    {
        public static string DecryptString(string value)
        {
            var initVectorBytes = Encoding.ASCII.GetBytes("@1B2c3D4e5F6g7H8");
            var saltValueBytes = Encoding.ASCII.GetBytes("s@1tValue");
            var cipherTextBytes = Convert.FromBase64String(value);
            var password = new PasswordDeriveBytes("Pas5pr@se", saltValueBytes, "SHA1", 2);
            var keyBytes = password.GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged {Mode = CipherMode.CBC};
            var decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            var plainTextBytes = new byte[cipherTextBytes.Length];        
            var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            //cryptoStream.Close();
            var plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            return plainText;
        }

    }
}

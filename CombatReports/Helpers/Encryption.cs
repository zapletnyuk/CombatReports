using CombatReports.DAL.Models;
using CombatReports.ManagingWindows;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CombatReports.Helpers
{
    class Encryption
    {
        public static byte[] Encrypt(byte[] data, Hash hash)
        {
            string hashInput;

        HashInput:
            var dialogHashInput = new DialogHashInput("Введіть хеш, будь ласка.", "");
            dialogHashInput.ShowDialog();
            hashInput = dialogHashInput.InputText;

            if (hash.HashValue.SequenceEqual(SHA256Hash.ComputeHash(hashInput)))
            {
                CustomMessageBox messageBox = new CustomMessageBox("Хеш підтверджено.");
                messageBox.ShowDialog();
                using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashInput));
                using TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
                ICryptoTransform transform = tripDes.CreateEncryptor();
                byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                return results;
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox("Невірний хеш. Повторіть, будь ласка, ще раз.");
                messageBox.ShowDialog();
                goto HashInput;
            }
        }

        public static byte[] Decrypt(byte[] data)
        {
            string hash = "myHash";
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return results;
                }
            }
        }
    }
}

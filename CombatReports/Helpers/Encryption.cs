using CombatReports.Data.Models;
using CombatReports.DialogWindows;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports.Helpers
{
    public static class Encryption
    {
        public static byte[] Encrypt(byte[] data, Hash hash)
        {
            string hashInput;

        HashInput:
            var dialogHashInput = new DialogHashInput(Constant.NeedToEnterEnterHashMessage, "");
            dialogHashInput.ShowDialog();
            hashInput = dialogHashInput.InputText;

            if (hash.Value.SequenceEqual(SHA256Hash.ComputeHash(hashInput)))
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.ConfirmedHashMessage);
                messageBox.ShowDialog();
                using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hashInput));
                using TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
                ICryptoTransform transform = tripDes.CreateEncryptor();
                byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                return results;
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.WrongHashMessage);
                messageBox.ShowDialog();
                goto HashInput;
            }
        }

        public static byte[] Decrypt(byte[] data, Hash hash)
        {
            string hashInput;

        HashInput:
            var dialogHashInput = new DialogHashInput(Constant.NeedToEnterEnterHashMessage, "");
            dialogHashInput.ShowDialog();
            hashInput = dialogHashInput.InputText;

            if (hash.Value.SequenceEqual(SHA256Hash.ComputeHash(hashInput)))
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.ConfirmedHashMessage);
                messageBox.ShowDialog();
                using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hashInput));
                using TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
                ICryptoTransform transform = tripDes.CreateDecryptor();
                byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                return results;
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.WrongHashMessage);
                messageBox.ShowDialog();
                goto HashInput;
            }
        }
    }
}
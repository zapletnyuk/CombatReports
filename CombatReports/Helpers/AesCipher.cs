using CombatReports.Data.Models;
using CombatReports.DialogWindows;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports.Helpers
{
    public static class AesCipher
    {
        public static byte[] Encrypt(byte[] data, Hash hash)
        {
            string keyInput;

        KeyInput:
            var dialogHashInput = new DialogKeyInput(Constant.NeedToEnterKeyMessage, "");
            dialogHashInput.ShowDialog();
            keyInput = dialogHashInput.InputText;

            if (hash.Key.SequenceEqual(SHA256Hash.ComputeHash(keyInput)))
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.ConfirmedHashMessage);
                messageBox.ShowDialog();

                using Aes aes = Aes.Create();
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = hash.Key;
                aes.IV = hash.Vector;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using MemoryStream msEncrypt = new MemoryStream();
                using CryptoStream cryptoStreamEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                cryptoStreamEncrypt.Write(data, 0, data.Length);
                cryptoStreamEncrypt.FlushFinalBlock();
                var result = msEncrypt.ToArray();

                return result;
            }
            else
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.WrongHashMessage);
                messageBox.ShowDialog();
                goto KeyInput;
            }
        }

        public static byte[] Decrypt(byte[] data, Hash hash)
        {
            string hashInput;

        HashInput:
            var dialogHashInput = new DialogKeyInput(Constant.NeedToEnterKeyMessage, "");
            dialogHashInput.ShowDialog();
            hashInput = dialogHashInput.InputText;

            if (hash.Key.SequenceEqual(SHA256Hash.ComputeHash(hashInput)))
            {
                CustomMessageBox messageBox = new CustomMessageBox(Constant.ConfirmedHashMessage);
                messageBox.ShowDialog();

                using Aes aes = Aes.Create();
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = hash.Key;
                aes.IV = hash.Vector;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using MemoryStream msDecrypt = new MemoryStream(data);
                using CryptoStream cryptoStreamDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
                var decrypted = new byte[data.Length];
                var bytesRead = cryptoStreamDecrypt.Read(decrypted, 0, decrypted.Length);

                return decrypted.Take(bytesRead).ToArray();
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
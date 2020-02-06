using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CombatReports.Helpers
{
    public static class GeneratedFileData
    {
        public static (string shortFileName, byte[] fileData) GetFileInfo(string path)
        {
            // Назва файлу
            string shortFileName = Path.GetFileNameWithoutExtension(path.Substring(path.LastIndexOf('\\') + 1));
            // Масив для збереження бінарних даних файла
            byte[] fileData;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fileData = new byte[fs.Length];
                fs.Read(fileData, 0, fileData.Length);
            }
            var fileInfo = (shortFileName, Encrypt(fileData));
            return fileInfo;
        }

        public static byte[] Encrypt(byte[] data)
        {
            string hash = "myHash";
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() 
                    { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return results;
                }
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

using CombatReports.DAL.Models;
using System.IO;

namespace CombatReports.Helpers
{
    public static class GeneratedFileData
    {
        public static (string shortFileName, byte[] fileData) GetFileInfo(string path, Hash hash)
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
            var fileInfo = (shortFileName, Encryption.Encrypt(fileData, hash));
            return fileInfo;
        }
    }
}

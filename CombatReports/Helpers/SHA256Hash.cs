using System.Security.Cryptography;
using System.Text;

namespace CombatReports.Helpers
{
    public static class SHA256Hash
    {
        public static byte[] ComputeHash(string dataToHash)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hashedData = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(dataToHash));
                return hashedData;
            }
        }
    }
}

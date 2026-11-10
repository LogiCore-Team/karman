using System.Security.Cryptography;
using System.Text;

namespace YAGOT_2._0.Services
{
    public class DealingAPI
    {
        private readonly IConfiguration _configuration;

        public DealingAPI(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string DecryptPhone(string? encryptedPhone)
        {
            if (string.IsNullOrWhiteSpace(encryptedPhone))
            {
                return string.Empty;
            }

            try
            {
                string key = _configuration["Encryption:Key"] ?? "7ab2C3d4E5f6G7h8I9j0Khs2M3n4Oiod";
                string iv = _configuration["Encryption:IV"] ?? "Xrj123lz6789Aa7D";

                if (key.Length < 32) key = key.PadRight(32, '0');
                if (key.Length > 32) key = key[..32];
                if (iv.Length < 16) iv = iv.PadRight(16, '0');
                if (iv.Length > 16) iv = iv[..16];

                using var aes = Aes.Create();

                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iv);

                using var decryptor = aes.CreateDecryptor();

                byte[] encryptedBytes = Convert.FromBase64String(encryptedPhone);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}

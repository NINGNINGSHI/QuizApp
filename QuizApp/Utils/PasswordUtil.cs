using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace QuizApp.Utils
{
    public class PasswordUtil
    {
        public static string GenerateSaltBytes()
        {
            int minSaltSize = 4;
            int maxSaltSize = 8;

            // Generate a random number for the size of the salt.
            Random random = new Random();
            int saltSize = random.Next(minSaltSize, maxSaltSize);
            byte[] saltBytes = new byte[saltSize];

            // Initialize a random number generator.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Fill the salt with cryptographically strong byte values.
            rng.GetNonZeroBytes(saltBytes);

            return Convert.ToBase64String(saltBytes);
        }

        public static string GenerateSaltedHash(string plainText, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            // Convert plain text into a byte array.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] saltedValue = plainTextBytes.Concat(saltBytes).ToArray();

            HashAlgorithm hash = new MD5CryptoServiceProvider();

            byte[] hashBytes = hash.ComputeHash(saltedValue);

            return Convert.ToBase64String(hashBytes);
        }

        public static bool ConfirmPassword(string password, string salt, string hashValue)
        {
            byte[] hashValueBytes = Convert.FromBase64String(hashValue);
            byte[] PasswordHash = Convert.FromBase64String(
                GenerateSaltedHash(password, salt));
            return PasswordHash.SequenceEqual(hashValueBytes);
        }
    }
}

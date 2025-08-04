using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class PasswordHasher
    {
        public static (byte[] hash, byte[]salt) HashPassword(
            string password,
            int iterations = 100_000,
            int saltSize = 16,
            int hashSize = 32)
        {
            byte[] salt = new byte[saltSize];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(salt);
            rng.Dispose();

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(hashSize);
            pbkdf2.Dispose();

            return (hash, salt);
        }
        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }
        public static bool VerifyPassword(string password, byte[] salt, byte[] expectedHash, int iterations = 100_000, int hashSize = 32)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(hashSize);
            pbkdf2.Dispose();

            // I used FixedTimeEquals because as a protection against timing attacks
            // although it kind of doesn't make sense to use, because users can't
            // enter hash values directly...
            return FixedTimeEquals(hash, expectedHash);
        }
    }
}

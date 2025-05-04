using System;
using System.Text;
using System.Security.Cryptography;

namespace ClassroomGamf.Services
{
    public static class AuthService
    {
        public static string HashPassword(string password)
        {
            var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool CheckPassword(string inputPassword, string storedHash)
        {
            var inputHash = HashPassword(inputPassword);
            return inputHash == storedHash;
        }
    }

}

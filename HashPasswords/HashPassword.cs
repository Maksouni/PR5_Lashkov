using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashPasswords
{
    public static class HashPassword
    {
        public static string HashPass(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] source = Encoding.UTF8.GetBytes(password);
                byte[] hashSource = sha256.ComputeHash(source);
                string hashPass = BitConverter.ToString(hashSource).Replace("-", String.Empty);
                return hashPass;
            }


        }
    }
}

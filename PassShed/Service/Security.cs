using System;
using System.Security.Cryptography;
using System.Text;

namespace PassShed.Service
{
    static class Security
    {
        public static string HashString(string input)
        {
            var md5 = new MD5CryptoServiceProvider();

            var utf8 = new UTF8Encoding();

            return BitConverter.ToString(md5.ComputeHash(utf8.GetBytes(input)));
        }
    }
}

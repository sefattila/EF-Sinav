using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sinav.BLL.Utilities
{
    public class ServiceHelper
    {
        public static bool PasswordControl(string password)
        {
            bool upperCase = password.Count(char.IsUpper) > 1 ? true : false;
            bool lowerCase = password.Count(char.IsLower) > 2 ? true : false;
            bool specialCharCount = Regex.Matches(password, "[!:+*]").Count > 1 ? true : false;
            if (upperCase && lowerCase && specialCharCount && password.Length > 7)
            {
                return true;
            }
            return false;
        }

        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

    }
}

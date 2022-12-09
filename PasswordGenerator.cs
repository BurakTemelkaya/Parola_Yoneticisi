using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Parola_Yoneticisi
{
    public static class PasswordGenerator
    {
        public static string GenerateRandomPassword(int length)
        {
            string valid = "abcçdefgğhıijklmnoöpqrsştuüvwxyzABCÇDEFGHIİJKLMNOPQRSTUVWXYZ1234567890,;#!éã~:@æß<>£^'+$½%&{/[(])}=?*_-";
            string s = "";
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while (s.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (valid.Contains(character))
                    {
                        s += character;
                    }
                }
            }
            return s;
        }
    }
}

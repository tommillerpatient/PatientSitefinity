using System;
using System.Security.Cryptography;
using System.Text;

namespace SitefinityWebApp.Mvc.Helpers
{
    public static class SecurityHelper
    {
        private static readonly byte[] Salt;
        private static readonly int IterationCount;
        private static readonly int KeyLength;
        private static readonly string Password = "eaf0485aece44b8af4ba110513a25d9e";

        static SecurityHelper()
        {
            Salt = "039afbed5a1c2570361a1656e6d79705".GetHexBytes();
            IterationCount = 10000;
            KeyLength = 32;
        }

        public static string GetSHA1(this string input)
        {
            using (var sha = SHA1.Create())
            {
                var data = sha.ComputeHash(input.GetBytes());
                return data.ToHex();
            }
        }

        public static string GetKey(this string input)
        {
            var key = new Rfc2898DeriveBytes(input, Salt, IterationCount).GetBytes(KeyLength);
            return key.ToHex();
        }

        public static string CreateToken(int length = 32)
        {
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                var data = new byte[length];
                rngCsp.GetBytes(data);
                return data.ToHex();
            }
        }

        public static string ToHex(this byte[] data)
        {
            var str = new StringBuilder();
            foreach (var b in data)
            {
                str.Append(b.ToString("x2"));
            }
            return str.ToString();
        }

        public static byte[] GetHexBytes(this string hex)
        {
            var bytes = new byte[hex.Length/2];
            for (var i = 0; i < hex.Length; i += 2)
                bytes[i/2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static byte[] GetBytes(this string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static string UrlEncrypt(string input)
        {
            return AesHelper.Encrypt(input.GetBytes(), Password).ToHex();
        }

        public static string UrlDecrypt(string input)
        {
            return Encoding.UTF8.GetString(AesHelper.Decrypt(input.GetHexBytes(), Password));
        }
    }
}
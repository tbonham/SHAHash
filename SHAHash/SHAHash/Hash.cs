using System;
using System.Text;
using System.Security.Cryptography;

namespace SHAHash
{
    public static class Hash
    {
        private const string Format = "x2";
        public static String SHA1Hash(String strValue)
        {
            using (SHA1 sha1Hash = new SHA1Managed())
            {
                byte[] bytes = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(strValue));
                StringBuilder sb = new StringBuilder();
                for(int i=0; i< bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString(Format));
                }
                return sb.ToString();
            }
        }
        public static String SHA256Hash(String strValue)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(strValue));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString(Format));
                }
                return sb.ToString();
            }
        }
        public static String SHA384Hash(String strValue)
        {
            using (SHA384 sha384Hash = SHA384.Create())
            {
                byte[] bytes = sha384Hash.ComputeHash(Encoding.UTF8.GetBytes(strValue));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString(Format));
                }
                return sb.ToString();
            }
        }
        public static String SHA512Hash(String strValue)
        {
            using (SHA512 sha512Hash = SHA512.Create())
            {
                byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(strValue));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString(Format));
                }
                return sb.ToString();
            }
        }
    }
}
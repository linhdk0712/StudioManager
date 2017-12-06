using System;
using System.Security.Cryptography;
using System.Text;

namespace StudioCommon
{
    public interface IEncrypt
    {
        string EncryptMd5(string data);
        int EncodeId(int value);
        int DecodeId(int value);
    }
    public class Encrypt : IEncrypt
    {
        public string EncryptMd5(string data)
        {
            var myMd5 = new MD5CryptoServiceProvider();
            var b = Encoding.UTF8.GetBytes(data);
            b = myMd5.ComputeHash(b);

            var s = new StringBuilder();
            foreach (var p in b)
            {
                s.Append(p.ToString("x").ToLower());
            }
           return s.ToString();
        }

        public int EncodeId(int value)
        {
            throw new NotImplementedException();
        }

        public int DecodeId(int value)
        {
            throw new NotImplementedException();
        }
    }
}
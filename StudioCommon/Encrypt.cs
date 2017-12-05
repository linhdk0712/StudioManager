using System.Security.Cryptography;
using System.Text;

namespace StudioCommon
{
    public interface IEncrypt
    {
        string EncryptMd5(string data);
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

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SistemadeControlPoliciaco
{
    class Hash
    {
        public static string sha1(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            StringBuilder stb = new StringBuilder();
            byte[] res = sha.ComputeHash(enc.GetBytes(str));
            for (int i = 0; i < res.Length; i++)
                stb.AppendFormat("{0:x2}", res[i]);
            return stb.ToString();
        }

        public static string md5(string str)
        {
            HashAlgorithm md5 = new MD5CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            StringBuilder stb = new StringBuilder();
            byte[] res = md5.ComputeHash(enc.GetBytes(str));
            for (int i = 0; i < res.Length; i++)
                stb.AppendFormat("{0:x2}", res[i]);
            return stb.ToString();
        }
        
    }
}

using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaABCBusiness.Services
{
    public class Descrypt
    {
        public static string GerarHashMd5(MD5 md5hash, string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static string RetornarMD5(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return GerarHashMd5(md5Hash, input);
            }
        }

        public bool ComparaMD5(string senhabanco, string Senha_MD5)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                if (VerificarHash(md5Hash, Senha_MD5, senhabanco))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool VerificarHash(MD5 md5Hash, string input, string hash)
        {
            StringComparer compara = StringComparer.OrdinalIgnoreCase;

            if (0 == compara.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}




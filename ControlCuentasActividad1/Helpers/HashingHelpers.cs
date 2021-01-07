using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ControlCuentasActividad1
{
    public static class HashingHelpers
    {
        public static string GetHash(string cadena)
        {
            var alg = SHA256.Create();
            byte[] codificar = System.Text.Encoding.UTF8.GetBytes(cadena);
            byte[] hash = alg.ComputeHash(codificar);

            string res = "";
            foreach (var b in hash)
            {
                res += b.ToString("X2");
            }
            return res;
        }
    }
}

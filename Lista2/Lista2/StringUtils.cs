using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    static class StringUtils
    {
        static string InverterString(string inverte)
        {
            //Converte a string inverte em um array de caracteres onde pode ser modificado
            char[] charArray = inverte.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChar
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static String DoubleChar(String str)
        {
            String result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i] + str[i];
            }

            return result;
        }
    }
}

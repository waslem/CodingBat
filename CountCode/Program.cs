using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCode
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int CountCode(String str)
        {
            int codeCounter = 0;
            for (int i = 0; i < str.Length-3; i++)
            {
                if (str[i] == 'c' && str[i + 1] == 'o' && str[i + 3] == 'e')
                    codeCounter++;
            }

            return codeCounter;
        }
    }
}

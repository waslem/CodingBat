using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XyzThere
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Boolean XyzThere(String str)
        {
            for (int i = 0; i < str.Length-3; i++)
            {
                if (str[i + 1] == 'x' && str[i + 2] == 'y' && str[i + 3] == 'z')
                {
                    if (i < 0 && str[i] != 'x')
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

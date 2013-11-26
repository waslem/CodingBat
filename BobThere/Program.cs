using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobThere
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static Boolean BobThere(String str)
        {
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == 'b' && str[i + 2] == 'b')
                {
                    return true;
                }
            }

            return false;
        }
    }
}

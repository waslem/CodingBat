using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountHi
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int CountHi(String str)
        {
            int count = 0;

            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == 'h' && str[i + 1] == 'i')
                    count++;
            }

            return count;

        }
    }
}

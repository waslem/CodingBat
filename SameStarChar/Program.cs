using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameStarChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SameStarChar("xy*yzz"));
            Console.WriteLine(SameStarChar("xy*zzz"));
            Console.WriteLine(SameStarChar("xa*ax"));

            Console.ReadLine();
        }

        public static Boolean SameStarChar(String str)
        {
            for (int i = 1; i < str.Length-2; i++)
            {
                if (str[i + 1] == '*')
                {
                    if (!(str[i] == str[i + 2]))
                        return false;
                }
            }

            return true;
        }
    }
}

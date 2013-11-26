using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeFront("Hello"));
            Console.WriteLine(DeFront("java"));
            Console.WriteLine(DeFront("away"));

            Console.ReadLine();
        }

        public static String DeFront(String str)
        {
            if (str[0] == 'a')
            {
                if (str[1] == 'b')
                    return str;
                else
                    return "a" + str.Substring(2, str.Length - 2);
            }
            else
            {
                if (str[1] == 'b')
                    return str.Substring(1, str.Length - 1);
                else
                    return str.Substring(2, str.Length - 2);
            }
        }
    }
}

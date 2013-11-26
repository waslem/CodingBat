using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatFront("Chocolate", 4));
            Console.WriteLine(RepeatFront("Chocolate", 3));

            Console.ReadLine();

        }

        public static String RepeatFront(String str, int n)
        {
            String sub = str.Substring(0, n);
            String result = "";

            for (int i = sub.Length; i > 0; i--)
                result += sub.Substring(0, i);

            return result;
        }
    }
}

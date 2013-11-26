using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatEnd("Hello", 3));
            Console.WriteLine(RepeatEnd("Hello", 2));
            Console.WriteLine(RepeatEnd("Hello", 1));

            Console.ReadLine();
        }

        public static String RepeatEnd(String str, int n)
        {
            String lastNchars = str.Substring(str.Length - n, n);
            String result = "";
            for (int i = 0; i < n; i++)
                result += lastNchars;

            return result;
        }
    }
}

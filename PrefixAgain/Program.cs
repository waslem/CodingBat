using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixAgain
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(PrefixAgain("abXYabc", 1));
            Console.WriteLine(PrefixAgain("abXYabc", 2));
            Console.WriteLine(PrefixAgain("abXYabc", 3));
            Console.WriteLine(PrefixAgain("aa", 1));
            Console.ReadLine();
        }

        public static Boolean PrefixAgain(String str, int n)
        {
            String prefixString = str.Substring(0, n);
            String fix = str.Substring(1, str.Length - 1);

            if (fix.Contains(prefixString))
                return true;

            return false;
        }
    }
}

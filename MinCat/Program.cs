using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinCat("Hello", "Hi"));
            Console.WriteLine(MinCat("Hello", "java"));
            Console.WriteLine(MinCat("java", "Hello"));
            Console.ReadLine();
        }

        public static String MinCat(String a, String b)
        {
            if (a.Length > b.Length)
                return a.Substring(a.Length - b.Length, b.Length) + b;
            else if (a.Length < b.Length)
                return a + b.Substring(b.Length - a.Length, a.Length);
            else
                return a + b;
        }
    }
}

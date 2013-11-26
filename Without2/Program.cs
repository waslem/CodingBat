using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Without2("HelloHe"));
            Console.WriteLine(Without2("HelloHi"));

            Console.ReadLine();
        }

        public static String Without2(String str)
        {
            String front2 = str.Substring(0, 2);
            String back2 = str.Substring(str.Length - 2, 2);
            String rest = str.Substring(2,str.Length-2);
            String result = "";

            if (front2 == back2)
                result = rest;
            else
                result = str;

            return result;
        }
    }
}

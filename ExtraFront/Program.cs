using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtraFront("Hello"));
            Console.WriteLine(ExtraFront("ab"));
            Console.WriteLine(ExtraFront("H"));
            Console.ReadLine();
        }

        public static String ExtraFront(String str)
        {
            string front2;
            if (str.Length > 1)
                front2 = str.Substring(0, 2);
            else
                front2 = str.Substring(0, 1);

            string result = "";
            for (int i = 0; i < 3; i++)
                result += front2;

            return result;
        }
    }
}

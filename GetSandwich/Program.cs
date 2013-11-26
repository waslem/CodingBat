using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSandwich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSandwich("breadjambread"));

            Console.ReadLine();
        }

        public static String GetSandwich(String str)
        {
            int middleStart = 0;
            int middleEnd = 0;
            for (int i = 0; i < str.Length-5; i++) {
                if (str.Substring(i, str.Length - i).StartsWith("bread"))
                    middleStart = i + 5;
            }
            for (int i = middleStart; i < str.Length-4; i++)  {
                String temp = str.Substring(i, str.Length - i);
                if (temp.StartsWith("bread"))
                    middleEnd = i;
            }
            if (middleStart == 0)
                return "";
            return str.Substring(middleStart, middleEnd-middleStart);
        }
    }
}

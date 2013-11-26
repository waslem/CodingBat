using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CatDog("catdog"));

            Console.ReadLine();
        }

        public static Boolean CatDog(String str)
        {
            int catCount = 0;
            int dogCount = 0;

            for (int i = 0; i < str.Length-2; i++)
            {
                if (str.Substring(i, 3).Equals("cat"))
                    catCount++;
                if (str.Substring(i, 3).Equals("dog"))
                    dogCount++;
            }

            if (catCount == dogCount)
                return true;
            return false;
        }
    }
}

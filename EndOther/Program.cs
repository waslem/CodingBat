using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EndOther("Hiabc", "abC"));

            Console.ReadLine();
        }

        public static Boolean EndOther(String a, String b)
        {
            if (a.ToLower().EndsWith(b.ToLower()))
                return true;
            else if (b.ToLower().EndsWith(a.ToLower()))
                return true;

            return false;
        }
    }
}

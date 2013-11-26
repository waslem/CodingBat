using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeChocolate(5, 5, 24));

            Console.ReadLine();
        }

        // We want make a package of goal kilos of chocolate. We have small bars (1 kilo each) and big bars (5 kilos each). 
        // Return the number of small bars to use, assuming we always use big bars before small bars.
        // Return -1 if it can't be done.
        //  makeChocolate(4, 1, 9) → 4
        //  makeChocolate(4, 1, 10) → -1
        //  makeChocolate(4, 1, 7) → 2

        public static int MakeChocolate(int small, int big, int goal)
        {
            int bigRemainder = goal % big;

            if (bigRemainder >= small)
                return bigRemainder - small;
            else return -1;

        }
    }
}

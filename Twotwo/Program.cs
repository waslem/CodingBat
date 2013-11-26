using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twotwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoTwo(new[] { 4, 2, 2, 3 }));
            Console.WriteLine(TwoTwo(new[] { 2, 2, 4 }));
            Console.WriteLine(TwoTwo(new[] { 2, 2, 4, 2 }));
            Console.WriteLine(TwoTwo(new[] { 2, 2, 2 }));

            Console.ReadLine();
        }

        public static Boolean TwoTwo(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2) {
                    if (i < nums.Length-1) {
                        if (!(nums[i + 1] == 2))
                            return false;
                        else
                            i++;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}

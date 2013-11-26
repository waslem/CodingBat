using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEverywhere(new[] { 1, 2, 1, 3 }, 1));
            Console.WriteLine(IsEverywhere(new[] { 1, 2, 1, 3 }, 2));
            Console.WriteLine(IsEverywhere(new[] { 1, 2, 1, 3, 4 }, 1));

            Console.ReadLine();
        }

        public static Boolean IsEverywhere(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length; i=i+2)
            {
                if (i + 1 == nums.Length)
                {
                    if (!(nums[i] == val))
                        return false;
                }
                else if (!(nums[i] == val || nums[i + 1] == val))
                    return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatSeparator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(RepeatSeparator("Word", "X", 3));
            Console.WriteLine(RepeatSeparator("This", "And", 2));
            Console.WriteLine(RepeatSeparator("This", "And", 1));
            Console.WriteLine(RepeatSeparator("AAA", "", 0));

            Console.ReadLine();
        }

        public static String RepeatSeparator(String word, String sep, int count)
        {
            String result = word;
            if (count == 0)
            {
                return word;
            }
            for (int i = 1; i < count; i++)
                result += sep + word;

            return result;
        }
    }
}

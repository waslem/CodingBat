using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StartWord("hippo", "hi"));
            Console.WriteLine(StartWord("hipp", "xip"));
            Console.WriteLine(StartWord("hippo", "i"));

            Console.WriteLine(StartWord("hippo", "zig"));
            Console.ReadLine();
        }

        public static String StartWord(String str, String word)
        {
            // matches if word appears at start of str.
            // except don't need to match first char of word

            String matchingTerm = word.Substring(1, word.Length-1);

            if (str.Substring(1, word.Length - 1).Equals(matchingTerm))
            {
                return str.Substring(0, word.Length);
            }
            else
                return "";
            //on a match, return the front of the str

            // otherwise return an empty string


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordEnds
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static String WordEnds(String str, String word)
        {
            // loop through the str 
            // for every instance of word, return str[i-1] 
            // 
            String result = "";
            for (int i = 1; i < str.Length; i++)
            {
                String temp = str.Substring(i, str.Length - i);

                if (temp.StartsWith(word))
                {
                    result += str[i].ToString();
                }
            }

            return result;
        }
    }
}

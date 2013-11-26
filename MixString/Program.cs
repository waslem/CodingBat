using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MixString("abc", "xyz"));

            Console.ReadLine();
        }

        public static String MixString(String a, String b)
        {
            String result = "";

            if (a.Length > b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                    result += (a[i].ToString() + b[i].ToString());

                result += a.Substring(b.Length, a.Length - b.Length);
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                    result += a[i].ToString() + b[i].ToString();

                result += b.Substring(a.Length, b.Length - a.Length);
            }

            return result;
        }
    }
}

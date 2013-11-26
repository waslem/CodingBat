using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WithoutX("xHix"));
            Console.WriteLine(WithoutX("Hxix"));

            Console.ReadLine();
        }

        public static String WithoutX(String str)
        {
            if (str.Length > 1)
            {
                if (str[0] == 'x')
                {
                    if (str[str.Length - 1] == 'x')
                        return str.Substring(1, str.Length - 1);
                    return str.Substring(1, str.Length);
                }
                else if (str[str.Length - 1] == 'x')
                    return str.Substring(0, str.Length - 1);
                else
                    return str;
            }
            else
            {
                if (str.Equals('x'))
                {
                    return "";
                }
                return str;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XyBalance
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Boolean XyBalance(String str)
        {
            int lastXindex = 0;
            int lastYindex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x')
                    lastXindex = i;
                if (str[i] == 'y')
                    lastYindex = i;
            }

            if (lastYindex > lastXindex)
                return true;
            return false;
        }
    }
}

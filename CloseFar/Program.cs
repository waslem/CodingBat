using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseFar
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static Boolean CloseFar(int a, int b, int c)
        {
            // if b or c is 'close'
            if (Math.Abs(a - b) <= 1)
            {
                if (Math.Abs(a-c) > 2 && Math.Abs(b-c) > 2)
                    return true;
                return false;
            }
                
            if(Math.Abs(a - c) < 2)
            {
                if (Math.Abs(a - b) > 2 && Math.Abs(b-c) > 2)
                    return true;
                return false;
            }
            return false;
        }
    }
}

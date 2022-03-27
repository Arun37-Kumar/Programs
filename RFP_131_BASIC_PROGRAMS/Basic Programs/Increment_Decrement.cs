using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Basic_Programs
{
    class Increment_Decrement
    {
        public static void increment_decrement()
        {
            int increment = 10, decrement = 10;
            increment++;
            Console.WriteLine(increment);
            ++increment;
            Console.WriteLine(increment);
            decrement--;
            Console.WriteLine(decrement);
            --decrement;
            Console.WriteLine(decrement);
        }
    }
}

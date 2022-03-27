using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Basic_Programs
{
    internal class Even_Odd
    {
        public static void checkEvenOrOdd(int number)
        {
            if (number%2 == 0)
            {
                Console.WriteLine("The number {0} is even.",number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.",number);
            }

        }
    }
}

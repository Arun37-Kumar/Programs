using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Sequence_Selection_Loop
{
    internal class factorial
    {
        public static void  factorialNumber()
        {
            int fact = 1;
            int number;
            Console.WriteLine("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i = number; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}

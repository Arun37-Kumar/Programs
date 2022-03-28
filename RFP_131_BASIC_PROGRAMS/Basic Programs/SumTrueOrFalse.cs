using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Basic_Programs
{
    internal class SumTrueOrFalse
    {
        public static void Result()
        {
            int number1, number2, sum;
            Console.WriteLine("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            if (sum > 20)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}

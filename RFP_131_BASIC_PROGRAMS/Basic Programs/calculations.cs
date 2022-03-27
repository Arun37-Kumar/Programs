using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Basic_Programs
{
    internal class calculations
    {
        public static void Calculations()
        {
            int firstNumber = 20;
            int secondNumber = 30;
            int SUM, MULTIPLICATION, SUBTRACTION;
            float DIVISION;
            SUM = firstNumber + secondNumber;
            MULTIPLICATION = secondNumber * firstNumber;
            SUBTRACTION = firstNumber - secondNumber;
            DIVISION = firstNumber / secondNumber;

            Console.WriteLine(DIVISION);
            Console.WriteLine(SUM);
            Console.WriteLine(MULTIPLICATION);
            Console.WriteLine(SUBTRACTION);
            Console.ReadLine();
        }
    }
}

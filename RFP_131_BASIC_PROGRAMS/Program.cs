using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basic Programs

            //Program1
            Basic_Programs.First_Program.FirstProgram();
            Basic_Programs.calculations.Calculations();
            Basic_Programs.Increment_Decrement.increment_decrement();
            Basic_Programs.Even_Odd.checkEvenOrOdd(34);
            Basic_Programs.Even_Odd.checkEvenOrOdd(33);
            Basic_Programs.SumTrueOrFalse.Result();
            Console.ReadLine();

            // Sequence, Selection & Loop
           int SumOfNaturalNumbers = Sequence_Selection_Loop.NaturalNumberAddition.Add();
           Console.WriteLine(SumOfNaturalNumbers);
            Sequence_Selection_Loop.FindTheMaximum findTheMax = new Sequence_Selection_Loop.FindTheMaximum();
            findTheMax.findTheMaximum();
            Sequence_Selection_Loop.factorial.factorialNumber();
            Console.ReadLine();
        }
    }
}

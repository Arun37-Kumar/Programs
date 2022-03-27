using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Sequence_Selection_Loop
{
    class NaturalNumberAddition
    {
        public static int Add()
        {
            int sum = 0;
           Console.WriteLine("Enter the number : ");
           int number = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }   
    }
}

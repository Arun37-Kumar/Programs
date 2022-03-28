using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_131_BASIC_PROGRAMS.Sequence_Selection_Loop
{
    internal class FindTheMaximum
    {
        public void findTheMaximum()
        {
            int first, second, third;
            Console.WriteLine("Enter the first number :");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number : ");
            third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("First number {0} is greater than second and third number.", first);
            }
            else if(second > third && second > first)
            {
                Console.WriteLine("Second number {0} is greater than first and third number.", second);
            }
            else
            {
                Console.WriteLine("Third number {0} is greater than first and second number.", third);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems_
{
    /*Problem 1: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
          The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.*/
    class problem1
    {
        public problem1()
        {
            int multiply = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    multiply += i;
                }
                else if(i % 5 == 0)
                {
                    multiply += i;
                }

            }
            Console.WriteLine(multiply);
        }


    }
}

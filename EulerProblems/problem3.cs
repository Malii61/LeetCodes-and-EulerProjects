using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems_
{
    /*A palindromic number reads the same both ways. 
     The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     Find the largest palindrome made from the product of two 3-digit numbers.*/
    class problem3
    {
        public problem3()
        {
            int palindrom = 998000;
            bool loop = true;
            while (loop)
            {

                if (palindrom % 10 == palindrom / 100000)
                {
                    if (palindrom / 10000 % 10 == palindrom % 100 / 10)
                    {

                        if (palindrom % 10000 / 1000 == palindrom % 1000 / 100)
                        {
                            for (int i = 999; i > 100; i--)
                            {
                                if(palindrom % i == 0 && palindrom / i < 1000)
                                {
                                    loop = false;
                                    Console.WriteLine("The palindrome number that looking for: " + palindrom);
                                    break;
                                }
                            }
                        }
                    }
                }
                palindrom--;
            }
            
        }
    }
}

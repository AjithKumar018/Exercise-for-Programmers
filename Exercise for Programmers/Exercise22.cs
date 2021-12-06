using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise22
    {
        public void Solution()
        {
            int nNumb1, nNumb2, nNumb3;

            Console.Write("Enter the first number : ");
            nNumb1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            nNumb2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number : ");
            nNumb3 = Convert.ToInt32(Console.ReadLine());


            if (nNumb1 > nNumb2 && nNumb1 > nNumb3)
            {
               Console.WriteLine("The largest number is " + nNumb1 + ".\n");
            }
            else if (nNumb2 > nNumb1 && nNumb2 > nNumb3)
            {
                Console.WriteLine("The largest number is " + nNumb2 + ".\n"); 
            }
            else
            {
                Console.WriteLine("The largest number is " + nNumb3 + ".\n");
            }
        }
    }
}


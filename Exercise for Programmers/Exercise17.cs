using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise17
    {
        public void Solution()
        {
            int nGender;
            double dAConsumed, dWeight, dNHours, dBAC = 0;
            

            Console.Write("Total Alcohol Consumed(oz): ");
            dAConsumed = Convert.ToDouble(Console.ReadLine());

            Console.Write("Weight(pounds): ");
            dWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("For Male Press 1, for Female Press 2: ");
            nGender = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Hours since last drink: ");
            dNHours = Convert.ToDouble(Console.ReadLine());

           if(nGender == 1)
            {
                dBAC = ((dAConsumed * 5.14) / (dWeight * 0.73)) - (.015 * dNHours);
            }
           else if(nGender == 2)
            {
                dBAC = ((dAConsumed * 5.14) / (dWeight * 0.66)) - (.015 * dNHours);
            }

           if(dBAC >= 0.08)
            {
                Console.Write(" \nYour BAC is " + dBAC);
                Console.Write("\nIt is not legal for you to drive.\n");
            }
           else
            {
                Console.Write(" \nYour BAC is " + dBAC);
                Console.Write("\nIt is legal for you to drive.\n");
            }
        }    
    }
}

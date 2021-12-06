using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise21
    {
        public void Solution()
        {
            int nMonth;
            Console.Write("Please enter the Number of the month: ");
            nMonth = Convert.ToInt32(Console.ReadLine());

            switch (nMonth)
            {
                case 1:
                    Console.Write("The name of the month is: January.\n\n");
                    break;
                case 2:
                    Console.Write("The name of the month is: Feburary.\n\n");
                    break;
                case 3:
                    Console.Write("The name of the month is: March.\n\n");
                    break;
                case 4:
                    Console.Write("The name of the month is: April.\n\n");
                    break;
                case 5:
                    Console.Write("The name of the month is: May.\n\n");
                    break;
                case 6:
                    Console.Write("The name of the month is: June.\n\n");
                    break;
                case 7:
                    Console.Write("The name of the month is: July.\n\n");
                    break;
                case 8:
                    Console.Write("The name of the month is: August.\n\n");
                    break;
                case 9:
                    Console.Write("The name of the month is: September.\n\n");
                    break;
                case 10:
                    Console.Write("The name of the month is: October.\n\n");
                    break;
                case 11:
                    Console.Write("The name of the month is: November.\n\n");
                    break;
                case 12:
                    Console.Write("The name of the month is: December.\n\n");
                    break;
                default:
                    Console.Write("Invalid Input!\n\n");
                    break;
            }
        }
    }
}

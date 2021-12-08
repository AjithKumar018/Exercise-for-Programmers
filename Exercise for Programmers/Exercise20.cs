using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise20
    {
        public void Solution()
        {
            int nAmt;
            string strState;
            double dTax, dTotal;

            Console.Write("What is the order amount? ");
            nAmt = Convert.ToInt32(Console.ReadLine());

            Console.Write("What state do you live in? ");
            strState = Console.ReadLine();



            if (strState == "Wisconsin" || strState == "wisconsin")
            {
                dTax = nAmt * 5.05 / 100;
                dTotal = dTax + nAmt;
                Console.Write("The tax is $" + Math.Round(dTax, 3) + ".\n");
                Console.Write("The total is $" + Math.Round(dTotal, 3) + ".\n");
            }
            else if (strState == "EauClaire" || strState == "eauclaire")
            {
                dTax = nAmt * 5.055 / 100;
                dTotal = dTax + nAmt;
                Console.Write("The tax is $" + Math.Round(dTax, 3) + ".\n");
                Console.Write("The total is $" + Math.Round(dTotal, 3) + ".\n");
            }
            else if (strState == "Dunn" || strState == "dunn")
            {
                dTax = nAmt * 5.054 / 100;
                dTotal = dTax + nAmt;
                Console.Write("The tax is $" + Math.Round(dTax, 3) + ".\n");
                Console.Write("The total is $" + Math.Round(dTotal, 3) + ".\n");
            }
            else if (strState == "Illinois" || strState == "illinois")
            {
                dTax = nAmt * 8.00 / 100;
                dTotal = dTax + nAmt;
                Console.Write("The tax is $" + Math.Round(dTax, 3) + ".\n");
                Console.Write("The total is $" + Math.Round(dTotal, 3) + ".\n");
            }

        }
    }
}

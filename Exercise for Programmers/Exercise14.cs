using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise14
    {
        public void Solution()
        {
            int nAmt;
            string strState, dSubTotal, dMNTotal;
            double dTax, dWITotal;

            Console.Write("What is the order amount? ");
            nAmt = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the state? ");
            strState = Console.ReadLine();

            dSubTotal = nAmt + ".00";

            dTax = 0.055 * nAmt;

            dMNTotal = nAmt + ".00";

            dWITotal = nAmt + dTax;
           
            if (strState == "WI")
            {
                Console.Write("\nThe subtotal is $" + dSubTotal + ".");
                Console.Write("\nThe tax is $" + dTax + ".");
                Console.Write("\nThe total is $" + dWITotal + ".\n");
            }
            else
            {
                Console.Write("\nThe total is $" + dMNTotal + ".\n");
            }
        }
    }
}

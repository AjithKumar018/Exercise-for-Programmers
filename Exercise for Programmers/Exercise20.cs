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

            if (strState == "Wisconsin")
            {
                dTax =
                Console.Write("The tax is $" + dTax + ".");
                Console.Write("The total is $" + dTotal + ".");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise26
    {
        public void Solution()
        {
            int nBal, nAPR, nMpay;

            Console.Write("What is your balance? ");
            nBal = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the APR on the card (as a percent)? ");
            nAPR = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the monthly payment you can make? ");
            nMpay = Convert.ToInt32(Console.ReadLine());

            //formula: n = -(1/30) * log(1+b/p(1-(1+i)30)) / log(1+i);

           

            Console.Write("It will take you  months to pay off this card.\n");
            
        }
    }
}

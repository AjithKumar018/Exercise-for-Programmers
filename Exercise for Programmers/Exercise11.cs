using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise11
    {
        public void Solution()
        {
            double dExEuro, dExRate, dUsd;

            Console.Write("How many euros are you exchanging? ");
            dExEuro = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the exchange rate? ");
            dExRate = Convert.ToDouble(Console.ReadLine());

            dUsd = dExEuro * dExRate / 100;

            Console.Write("\n" + dExEuro + " euros at an exchange rate of " + Math.Round(dExRate,2) + " is " + Math.Round(dUsd,2) + " U.S. dollars.\n\n");
        }
    }
}

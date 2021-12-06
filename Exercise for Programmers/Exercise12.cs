using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise12
    {
        public void Solution()
        {
            int nPricipal, nYears;
            double dIntrest, dAverage, dTotal, dWorth;

            Console.Write("Enter the principal: ");
            nPricipal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the rate of interest: ");
            dIntrest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            nYears = Convert.ToInt32(Console.ReadLine());

            dAverage = dIntrest/ 100 * nPricipal; 

            dTotal = dAverage * nYears;

            dWorth = dTotal + nPricipal;

            Console.WriteLine("After " + nYears + " years at " + dIntrest + "%, the investment will be worth $" + dWorth +".");

        }
    }
}

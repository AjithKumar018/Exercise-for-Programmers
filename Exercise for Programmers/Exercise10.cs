using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise10
    {
        public void Solution()
        {
            int nItem1, nQItem1, nTItem1, nItem2, nQItem2, nTItem2, nItem3, nQItem3, nTItem3;
            double dSTotal, dTax, dTotal;

            Console.Write("\nEnter the price of item 1: ");
            nItem1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the quantity of item 1: ");
            nQItem1 = Convert.ToInt32(Console.ReadLine());

            nTItem1 = nItem1 * nQItem1;

            Console.Write("\nEnter the price of item 2: ");
            nItem2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the quantity of item 2: ");
            nQItem2 = Convert.ToInt32(Console.ReadLine());

            nTItem2 = (nItem2 * nQItem2);

            Console.Write("\nEnter the price of item 3: ");
            nItem3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the quantity of item 3: ");
            nQItem3 = Convert.ToInt32(Console.ReadLine());

            nTItem3 = (nItem3 * nQItem3);

            dSTotal = nTItem1 + nTItem2 + nTItem3;

            Console.Write("\nSubtotal: $" + dSTotal + ".00\n");

            dTax = 0.055 * dSTotal;

            Console.Write("\nTax: $" + Math.Round(dTax, 2) + "\n");

            dTotal = dTax + dSTotal;

            Console.Write("\nTotal: $" + Math.Round(dTotal, 2) + "\n\n");

        }
    }
}

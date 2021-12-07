using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise13
    {
        public void Solution()
        {
            int nPrincipal, nYear, nCYear;
            double dRate, dTotal;
           
                Console.Write("Enter the principal: ");
                nPrincipal = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the rate? ");
                dRate = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is the number of years? ");
                nYear = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the number of times the interestis compounded per year ? ");
                nCYear = Convert.ToInt32(Console.ReadLine());
                             
                dTotal = nPrincipal * Math.Pow((1 + (dRate / 100) / nCYear), (nCYear * nYear));
                Console.WriteLine("\n$" + nPrincipal + " invested at " + dRate + "% for " + nYear + " years compounded " + nCYear + " times per year is $" + Math.Round(dTotal,2) + ".");
        }
    }
}


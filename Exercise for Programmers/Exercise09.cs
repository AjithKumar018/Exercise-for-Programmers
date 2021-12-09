using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise09
    {
        public void Solution()
        {
            int nLength, nWidth, nPaint, nSqFeet;

            Console.Write("Length: ");
            nLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width: ");
            nWidth = Convert.ToInt32(Console.ReadLine());

            nSqFeet = nLength * nWidth;

            if(nSqFeet % 350 == 0)
            {
                nPaint = (nSqFeet / 350);
            }
            else
            {
                nPaint = (nSqFeet / 350) + 1;
            }

            Console.WriteLine("\nYou will need to purchase " + nPaint + " gallons of paint to cover " + nSqFeet + " square feet.\n");
        }
    }
}

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
            int nLength, nWidth, nPaint, nSqrFeet;

            Console.Write("Length: ");
            nLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width: ");
            nWidth = Convert.ToInt32(Console.ReadLine());

            nSqrFeet = nLength * nWidth;

            if(nSqrFeet % 350 == 0)
            {
                nPaint = (nSqrFeet / 350);
            }
            else
            {
                nPaint = (nSqrFeet / 350) + 1;
            }

            Console.WriteLine("\nYou will need to purchase " + nPaint + " gallons of paint to cover " + nSqrFeet + " square feet.\n");
        }
    }
}

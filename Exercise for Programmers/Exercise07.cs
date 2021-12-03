using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLength, nWidth, nSquareFeet;
            double dSquareMeters;

            Console.Write("What is the length of the room in feet? ");
            nLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the width of the room in feet? ");
            nWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nYou entered dimensions of " + nLength + " feet by " + nWidth + " feet.");

            nSquareFeet = nLength * nWidth;

            dSquareMeters = (nSquareFeet * 0.09290304);

            Console.Write("\n\nThe area is " + nSquareFeet + " square feet, " + "\n" + Math.Round(dSquareMeters, 3) + " square meters. \n");

        }
    }
}

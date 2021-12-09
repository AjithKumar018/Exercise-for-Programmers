using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise05
    {
        public void Solution()
        {
            int nFirstNumber, nSecondNumber, nAdd, nSub, nMult, nDiv;

            Console.Write("What is the first number? ");
            nFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the second number? ");
            nSecondNumber = Convert.ToInt32(Console.ReadLine());

            nAdd = nFirstNumber + nSecondNumber;
            nSub = nFirstNumber - nSecondNumber;
            nMult = nFirstNumber * nSecondNumber;
            nDiv = nFirstNumber / nSecondNumber;

            Console.WriteLine(nFirstNumber + " + " + nSecondNumber + " = " + nAdd);
            Console.WriteLine(nFirstNumber + " - " + nSecondNumber + " = " + nSub);
            Console.WriteLine(nFirstNumber + " * " + nSecondNumber + " = " + nMult);
            Console.WriteLine(nFirstNumber + " / " + nSecondNumber + " = " + nDiv);
        }
    }
}
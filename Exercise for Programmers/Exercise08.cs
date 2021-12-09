using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise08
    {
        public void Solution()
        {
            int nPeople, nPizza, nTPiece, nLPiece, nPTaken, nEach;

            Console.Write("How many people? ");
            nPeople = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many pizzas do you have? ");
            nPizza = Convert.ToInt32(Console.ReadLine());

            nTPiece = nPizza * 8;

            nEach = 2;

            nPTaken = nPeople * 2;

            nLPiece = nTPiece - nPTaken;

            Console.Write("\n" + nPeople + " people with " + nPizza + " Pizzas\n");

            Console.Write("Each person gets " + nEach + " Pieces of pizza.");
            Console.Write("\nThere are " + nLPiece + " leftover pieces.\n");
        }
    }
}

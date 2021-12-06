using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise15
    {
        public void Solution()
        {
            int nPin;

            Console.Write("What is the password? ");
            nPin = Convert.ToInt32(Console.ReadLine());

            if (nPin != 12345 )
            {
                Console.WriteLine("I don't know you.\n");
            }
            else
            {
                Console.WriteLine("Welcome!\n");
            }
        }
    }
}

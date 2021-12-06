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
            String strPin;

            Console.Write("What is the password? ");
            strPin = Console.ReadLine();

            if (strPin != "abc$123")
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise16
    {
        public void Solution()
        {
            int nAge;

            Console.Write("What is your age? ");
            nAge = Convert.ToInt32(Console.ReadLine());

            if (nAge < 18)
            {
                Console.WriteLine("You are not old enough to legally drive.\n");
            }
            else
            {
                Console.WriteLine("You are old enough to legally drive.\n");
            }
        }
    }
}

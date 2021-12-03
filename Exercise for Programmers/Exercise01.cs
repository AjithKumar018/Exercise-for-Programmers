using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise01
    {
        public void Solution()
        {
            string strHello;

            Console.Write("What is Your Name? ");
            strHello = Console.ReadLine();

            Console.WriteLine("Hello, " + strHello + ", nice to meet you!");
        }
    }
}
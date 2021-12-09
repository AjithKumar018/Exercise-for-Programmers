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
            string strName;

            Console.Write("What is Your Name? ");
            strName = Console.ReadLine();

            Console.WriteLine("Hello, " + strName + ", nice to meet you!\n");
        }
    }
}
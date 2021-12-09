using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise02
    {
        public void Solution()
        {
            string strInput;

            Console.Write("What is the input string? ");
            strInput = Console.ReadLine();


            Console.WriteLine(strInput + " has" + " " + strInput.Length + " Characters.\n");
        }
    }
}
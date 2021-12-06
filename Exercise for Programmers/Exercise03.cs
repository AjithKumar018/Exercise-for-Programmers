using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise03
    {
        public void Solution()
        {
            string strTxt;

            Console.Write("What is the quote? These aren't the droids you're looking for. \nWho said it? ");
            strTxt = Console.ReadLine();

            Console.WriteLine(strTxt + " says, \"These aren't the droids you're looking for.\"\n");
        }
    }
}

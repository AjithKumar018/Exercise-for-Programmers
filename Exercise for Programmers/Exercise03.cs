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
            string strQuote, strName;

            Console.Write("What is the quote? ");
            strQuote = Console.ReadLine();

            Console.Write("Who said it? ");
            strName = Console.ReadLine();

            Console.WriteLine(strName + " says, " + "\"" + strQuote + "\"\n");
        }
    }
}

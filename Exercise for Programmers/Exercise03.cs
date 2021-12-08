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
            string strText, strName;

            Console.Write("What is the quote? ");
            strText = Console.ReadLine();

            Console.Write("Who said it? ");
            strName = Console.ReadLine();

            Console.WriteLine(strName + " says, " + "\"" + strText + "\"\n");
        }
    }
}

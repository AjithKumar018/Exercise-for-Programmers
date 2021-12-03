using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise04
    {
        public void Solution()
        {
            string strNoun, strVerb, strAdjective, strAdverb;

            Console.Write("Enter a noun: ");
            strNoun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            strVerb = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            strAdjective = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            strAdverb = Console.ReadLine();

            Console.Write("Do you " + strVerb + " your " + strAdjective + " " + strNoun + " " + strAdverb + "? That's hilarious! \n");
        }
    }
}

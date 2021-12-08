using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise24
    {
        public void Solution()
        {
            string strFString, strSString;

            Console.WriteLine("Enter two strings and I'll tell you if they are anagrams: ");

            Console.Write("Enter the first string : ");
            strFString = Console.ReadLine();

            Console.Write("Enter the second string: ");
            strSString = Console.ReadLine();

            if (strFString == strSString)
            {
                Console.Write("\n" + "\"" + strFString + "\"" + " and " + "\"" + strSString + "\"" + " are anagrams. \n\n");
            }
            else
            {
                Console.Write("\n" + "\"" + strFString + "\"" + " and " + "\"" + strSString + "\"" + " are not anagrams. \n\n");
            }
        }
    }
}

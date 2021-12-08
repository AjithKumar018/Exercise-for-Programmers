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
            Console.WriteLine("Enter two strings and I'll tell you if they are anagrams: ");

            Console.Write("Enter the first string: ");
            string strFString = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string strSString = Console.ReadLine();

            if (IsAnagram(strFString, strSString))
            {
                Console.WriteLine("\"" + strFString + "\" and " + "\"" + strSString + "\" are anagrams.\n");
            }
            else
            {
                Console.WriteLine("\"" + strFString + "\" and " + "\"" + strSString + "\" are not anagrams.\n");
            }            
        }

        public bool IsAnagram(string str1, string str2)
        {
            foreach(char i in str1)
            {
                if (str2.IndexOf(i)== -1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

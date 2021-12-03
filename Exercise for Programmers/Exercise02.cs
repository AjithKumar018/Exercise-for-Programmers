using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTxt;

            Console.Write("What is the input string? ");
            strTxt = Console.ReadLine();


            Console.WriteLine(strTxt + " has" + " " + strTxt.Length + " Characters.");
        }
    }
}
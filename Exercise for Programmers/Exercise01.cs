using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHello;

            Console.Write("What is Your Name? ");
            strHello = Console.ReadLine();

            Console.WriteLine("Hello, " + strHello + ", nice to meet you!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise18
    {
        public void Solution()
        {
            int nCelsius, nFahrenheit;
            string strChoice;
            double dC, dF;

            Console.Write("Press C to convert from Fahrenheit to Celsius. ");
            Console.Write("\nPress F to convert from Celsius to Fahrenheit. ");
            Console.Write("\nYour Choice: ");
            strChoice = Console.ReadLine();

            if (strChoice == "c")
            {
                Console.Write("Please enter the temperature in Fahrenheit: ");
                nFahrenheit = Convert.ToInt32(Console.ReadLine());
                dC = (nFahrenheit - 32) * 5 / 9;
                Console.WriteLine(dC);
            }
            else if (strChoice == "f")
            {
                Console.Write("Please enter the temperature in Celsius: ");
                nCelsius = Convert.ToInt32(Console.ReadLine());
                dF = (nCelsius * 9 / 5) + 32; 
                Console.WriteLine(dF);
            }
            else
            {
                Console.WriteLine("Invalid Key!");
            }   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise06
    {
        public void Solution()
        {
            int nAge, nRetireAge, nCurrentYear, nLeftYears, nRetireYear;

            Console.Write("What is your current age? ");
            nAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("At what age would you like to retire? ");
            nRetireAge = Convert.ToInt32(Console.ReadLine());

            nCurrentYear = 2021;

            nLeftYears = nRetireAge - nAge;

            nRetireYear = nCurrentYear + nLeftYears;

            Console.WriteLine("\nYou have " + nLeftYears + " years left until you can retire.");
            Console.WriteLine("It's " + nCurrentYear + ", so you can retire in " + nRetireYear + ".");

        }
    }
}

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
            int nAge, nRetAge, nCurYear, nLeftYears, nRetYear;

            Console.Write("What is your current age? ");
            nAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("At what age would you like to retire? ");
            nRetAge = Convert.ToInt32(Console.ReadLine());

            nCurYear = 2021;

            nLeftYears = nRetAge - nAge;

            nRetYear = nCurYear + nLeftYears;

            Console.WriteLine("\nYou have " + nLeftYears + " years left until you can retire.");
            Console.WriteLine("It's " + nCurYear + ", so you can retire in " + nRetYear + ".");

        }
    }
}

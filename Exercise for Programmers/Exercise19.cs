using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise19
    {
        public void Solution()
        {
            double dBMI, dWeight, dHeight; 
           
            Console.Write("Enter your Weight(Pound): ");
            dWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Height(Inches): ");
            dHeight = Convert.ToDouble(Console.ReadLine());

            dBMI = (dWeight / (dHeight * dHeight)) * 703;

            Console.Write("\n\nYour BMI is " + Math.Round(dBMI,2));    

            if (dBMI > 18.5 && dBMI < 25) 
            {
                Console.Write("\n\nYou are within the ideal weight range.\n\n");
            }
            else
            {
                Console.Write("\n\nYou are overweight. You should see your doctor.\n\n");
            }
        }
    }
}

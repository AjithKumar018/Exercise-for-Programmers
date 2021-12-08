using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_for_Programmers
{
    class Exercise23
    {
        public void Solution()
        {
            char cAns;

            Console.Write("Is the car silent when you turn the key? ");
            cAns = Convert.ToChar(Console.ReadLine());

            if (cAns == 'y' || cAns == 'Y')
            {
                Console.Write("Are the battery terminals corroded? ");
                cAns = Convert.ToChar(Console.ReadLine());
                if ((cAns == 'n' || cAns == 'N'))
                {
                    Console.Write("Replace cables and try again. \n");
                }
                else if (cAns == 'y' || cAns == 'Y')
                {
                    Console.Write("Clean terminals and try starting again. \n");
                }
            }
            else if (cAns == 'n' || cAns == 'N')
            {
                Console.Write("Does the car make a clicking noise? ");
                cAns = Convert.ToChar(Console.ReadLine());
                if (cAns == 'y' || cAns == 'Y')
                {
                    Console.Write("Replace the battery. \n");
                }
                else if (cAns == 'n' || cAns == 'N')
                {
                    Console.Write("Does the car crank up but fail to start? ");
                    cAns = Convert.ToChar(Console.ReadLine());
                    if (cAns == 'y' || cAns == 'Y')
                    {
                        Console.Write("Check spark plug connections. \n");
                    }
                    else if (cAns == 'n' || cAns == 'N')
                    {
                        Console.Write("Does the engine start and then die? ");
                        cAns = Convert.ToChar(Console.ReadLine());
                        if (cAns == 'y' || cAns == 'Y')
                        {
                            Console.Write("Does your car have fuel injection? ");
                            cAns = Convert.ToChar(Console.ReadLine());
                            if (cAns == 'n' || cAns == 'N')
                            {
                                Console.Write("Check to ensure the chocke is opening and closing. \n");
                            }
                            else if (cAns == 'y' || cAns == 'Y')
                            {
                                Console.Write("Get it in for service. \n");
                            }
                      
                        }
                        else if(cAns == 'n' || cAns == 'N')
                        {
                            Console.Write("You have no other question pls select \"yes\" \n");
                        }
                    
                    }
                }
            }
            else
            {
                Console.Write("Invalid Selection. Select: Y / N.\n");
            }
        }
    }
}
                    
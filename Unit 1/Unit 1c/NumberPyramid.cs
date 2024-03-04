using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start program and prompt user to enter a number and take the
            //input and store it as a variable iterations
            //this will be used to set how long the loops will run
            Console.Write("Enter an integer: ");
            int iterations = int.Parse(Console.ReadLine());

            //Some inputs are just too big, if it's above 100 you'll be sitting there for awhile
            //this is to prevent that
            if (iterations >= 1001)
            {
                Console.WriteLine("Don't do that!");
            }

            //Here is the nested loop that will go through and build the pyramid
            //the names of the variables for the loops are outer loop and inner loop
            //to help with comprehension and to make it easier to use
            else
            {
                for (int outerLoop = 1; outerLoop < iterations + 1; outerLoop++)
                {
                    for (int innerLoop = 0; innerLoop < outerLoop; innerLoop++)
                    {
                        Console.Write(outerLoop);
                    }
                    Console.WriteLine();
                }
            }
            //Readline at the end to stop the command prompt window from disappearing after output is given
            Console.ReadLine();
        }
    }
}

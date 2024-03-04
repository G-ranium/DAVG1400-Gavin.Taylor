using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1C_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate a random number for the user to guess between 1 and 10, then give the user a prompt
            Random rnd = new Random();
            int luckyNumber = rnd.Next(1, 11);
            Console.WriteLine("I'm thinking of number between 1 and 10, what is it?");

            //while loop to go through until the user gets the right number
            int guesses = 0;
            while(true)
            {
                int guess = int.Parse(Console.ReadLine());
                //if they guess too high, they see this
                if(guess > luckyNumber)
                {
                    Console.WriteLine("Too high, try a lower number");
                    guesses += 1;
                }
                //too low and they get this prompt
                else if(guess < luckyNumber)
                {
                    Console.WriteLine("Too low, try a higher number");
                    guesses += 1;
                }
                //an else statement if they get it right (if its not greater than or less than then it has to be the number
                //the guesses is increased before giving the congratulation message because otherwise it will be wrong
                else
                {
                    guesses += 1;
                    Console.WriteLine($"Congratulations the number was {luckyNumber}!");
                    Console.WriteLine($"It took you {guesses} time(s) to get it right");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

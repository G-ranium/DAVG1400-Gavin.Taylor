using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Initial practice with each type of the following variables:
            Integer
            Double
            Char
            String
            Bool

            Afterwards, with these variables I will do various functions using the follwing
            using all operators*/

            int IntNumber = 10;
            double DoubleNumber = 10.5;
            char FirstLetter = 'B';
            char SecondLetter = 'O';
            string Name = "Bob";
            bool NameIsBob = true;

            // +
            Console.WriteLine($"You can spell the name {Name} as " + FirstLetter + "-" + SecondLetter + "-" + FirstLetter);
            // -
            Console.WriteLine($"{DoubleNumber} - 0.5 = {DoubleNumber - 0.5}");
            // *
            Console.WriteLine($"{IntNumber} * 10 = {IntNumber * 10}");
            // /
            Console.WriteLine($"{IntNumber} / 10 = {IntNumber / 10}");
            // %
            Console.WriteLine($"The remainder of {IntNumber} / 3 is {IntNumber % 3}");
            // ++
            IntNumber++;
            Console.WriteLine($"10 + 1 = {IntNumber}");
            // --
            IntNumber--;
            Console.WriteLine($"11 - 1 = {IntNumber}");

            // +=
            IntNumber += 30;
            Console.WriteLine($"10 + 30 = {IntNumber}");
            // -=
            IntNumber -= 10;
            Console.WriteLine($"40 - 10 = {IntNumber}");
            // *=
            IntNumber *= 2;
            Console.WriteLine($"30 * 2 = {IntNumber}");
            // /=
            IntNumber /= 10;
            Console.WriteLine($"60 / 10 = {IntNumber}");

            // =
            Console.WriteLine("What is your name? ");
            Name = Console.ReadLine();

            // ==
            if (Name == "Bob")
            {
                Console.WriteLine("Your name is Bob");
            }
            else
            {
                NameIsBob = false;
            }
            // !=
            if (NameIsBob != true)
            {
                Console.WriteLine($"You are not Bob you are {Name}");
            }

            // >
            Console.WriteLine($"3 is bigger than 4: {3 > 4}");
            // <
            Console.WriteLine($"3 is smaller than 4: {3 < 4}");
            // >=
            Console.WriteLine($"9 is greater than or equal to 4 {9 >= 3}");
            // <=
            Console.WriteLine($"9 is less than or equal to 4 {9 <= 3}");

            // &&  
            // ||
            // !
            Console.WriteLine("This next sentence is True");
            Console.WriteLine(true && true || false || !false);
            Console.WriteLine("This next sentence is False");
            Console.WriteLine(true && !true || false || false);


            /*This next bit of code is a project from CS 1400 written in C# instead of python
             *This program takes the crew of Yondu from Guardians of the galaxy and divides
             *plunder among crew members. 3 is given to each crew member while Yondu
             *and peter take their share. Yondu takes 13% and Peter takes 11% of what is left
             *and then the rest is divided evenly among every crew member including Peter
             *and Yondu*/
            Console.WriteLine("Do you want to continue to Yondu Project? Y/N");
            string Continue = Console.ReadLine();
            if (Continue == "Y")
            {
                //Get user input, number of pirates and units. Code will not validate input
                Console.WriteLine("Number of pirates: ");
                int Pirates = int.Parse(Console.ReadLine());
                Console.WriteLine("Number of Units");
                double Units = double.Parse(Console.ReadLine());

                //each pirate excluding Peter and Yondu gets 3 units, exclude this info to calculate
                Units = Units - (3 * (Pirates - 2));

                //Calculate Yondu's share:
                double YonduShare = Math.Round((Units * 0.13), 2);
                Units -= YonduShare;

                //Calculate Peter's share:
                double PeterShare = Math.Round((Units * 0.11), 2);
                Units -= PeterShare;


                //Calculate Crew's Share
                Units = Math.Round((Units / Pirates), 2);
                YonduShare += Units;
                PeterShare += Units;

                //Include the 3 Units in the share that were taken at the beginning
                Units += 3;

                //Print results to user
                Console.WriteLine($"Yondu's share: {YonduShare:N2}");
                Console.WriteLine($"Peter's share: {PeterShare:N2}");
                Console.WriteLine($"Crew share: {Units:N2}");

                //End program
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
            if (Continue == "N")
            {
                Console.WriteLine("GoodBye");
            }
            else
            {
                Console.WriteLine("Wasn't a Y or N so goodbye anyway");
            }
        }
    }
}

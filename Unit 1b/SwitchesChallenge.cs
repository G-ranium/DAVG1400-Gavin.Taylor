using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsLab
{
    class Program
    {
        static void Main()
        {
            //import functions (for temperature and exams) as f because I am lazy
            var f = new Functions();

            //for the temperature
            Console.WriteLine("Please enter the temperature in celsius");
            f.tempAdvisor(int.Parse(Console.ReadLine()));

            //for the exam
            Console.WriteLine("Please enter your exam score %");
            f.examGrader(int.Parse(Console.ReadLine()));

            //Favorite subject
            Console.WriteLine("Please enter your favorite subject");
            f.favSubject(Console.ReadLine());

            //read line to give user a chance to read output
            Console.ReadLine();
        }
    }
    public class Functions
    {
        public void tempAdvisor(int temp)
        {
            //if temp is greater than 30 it will print a comment about the temperature
            if (temp > 30)
            {
                Console.WriteLine("It's hot! Make sure to drink lots of water and to avoid sun exposure for extended periods.");
            }
            else if (temp <= 30 & temp > 10)
            {
                Console.WriteLine("The weather is pleasant! Enjoy your day!");
            }
            //anything below like 10 is starting to get cold and will no longer be very pleasant...
            else
            {
                Console.WriteLine("It's cold! Make sure to wear a jacket and drink hot cocoa");
            }
        }
        public void examGrader(int percent)
        {
            //pretty straightfoward, if they get a 90 its an A.
            //If else if is changed to "if" the program will return
            //all the different inputs that fall into the same category
            //for example it would return that you got an a b c d and f if you put 90
            //for that reason we will keep it as an else if
            if (percent >= 90)
            {
                Console.WriteLine("Your grade is an A");
            }
            else if (percent >= 80)
            {
                Console.WriteLine("Your grade is a B");
            }
            else if (percent >= 70)
            {
                Console.WriteLine("Your grade is a C");
            }
            else if (percent >= 60)
            {
                Console.WriteLine("Your grade is a D");
            }
            else
            {
                Console.WriteLine("Your grade is an F");
            }
        }
        public void favSubject(string subject)
        {
            switch(subject)
            {
                case "math":
                    Console.WriteLine("Keep it up! You're really smart! Maybe you could be an engineer!");
                    break;
                case "english":
                    Console.WriteLine("Wow... i need sum help with my inglish.. maybee u can help me spell better");
                    break;
                case "science":
                    Console.WriteLine("You really know your stuff, keep going and you'll be the next Darwin!");
                    break;
                case "history":
                    Console.WriteLine("I see, you have a refined taste. Help us to discover more wonders of the world!");
                    break;
                case "art":
                    Console.WriteLine("That's awesome! I bet your artwork is amazing... can you make a painting of me?");
                    break;
                case "pe":
                    Console.WriteLine("Yeah!! Get that bread. Keep it up and you'll be a body builder!");
                    break;
                case "band":
                    Console.WriteLine("One day you will be a musician! Keep making wonderful music!");
                    break;

            }
        }
    }
}

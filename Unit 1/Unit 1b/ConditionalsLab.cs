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
    }
}

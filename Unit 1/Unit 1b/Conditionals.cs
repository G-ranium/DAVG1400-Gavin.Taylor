using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1b
{
    class Program
    {
        public Operations myOperator;
        public void Main()
        {
            myOperator = new Operations();

            Console.WriteLine("What's the password?");
            myOperator.Password(Console.ReadLine());

            Console.WriteLine("How much did you pay? ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("How much would you like to tip in %? ");
            double tip = double.Parse(Console.ReadLine());
            myOperator.calculateTip(price, tip);

            Console.WriteLine("Please enter an integer");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another integer");
            int num2 = int.Parse(Console.ReadLine());
            myOperator.Compare(num1, num2);
        }
    }
    public class Operations
    {
        public void calculateTip(double value1, double value2)
        {
            var number = value1 * (value2 / 100);
            Console.WriteLine($"The tip is {number} your total will be {(number + value1)}");
            Console.ReadLine();
        }
        public void Compare(int value1, int value2)
        {
            if (value1 > value2)
            {
                Console.WriteLine($"{value1} is greater than {value2}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{value2} is greater than {value1}");
                Console.ReadLine();
            }
        }
        public void Password(string password)
        {
            if (password == "openSesame")
            {
                Console.WriteLine("Password is correct");
            }
            else
            {
                Console.WriteLine("C'mon man you aren't supposed to be here...");
            }
        }
    }
}

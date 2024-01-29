using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How much did you pay? ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("How much would you like to tip in %? ");
            double tip = double.Parse(Console.ReadLine());
            calculateTip(price, tip);



        }

        public static void calculateTip (double value1, double value2)
        {
            var number = value1 * (value2 / 100);
            Console.WriteLine($"The tip is {number} your total will be {(number + value1)}");
            Console.ReadLine();
        }
    }
}

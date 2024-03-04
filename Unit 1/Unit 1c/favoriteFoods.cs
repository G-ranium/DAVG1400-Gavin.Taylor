using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Foods
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an empty array to be edited
            string[] favoriteFoods = { };

            //prompt user to input 3 foods and add to the array
            Console.WriteLine("What are your 3 most favorite foods?");
            for (int i = 0;i < 3 ;i++)
            {
                favoriteFoods = favoriteFoods.Append(Console.ReadLine()).ToArray();
            }

            //print out just how much you love that yummy yummy food
            foreach(string food in favoriteFoods)
            {
                Console.WriteLine($"I love {food}!");
            }
            Console.ReadLine();
        }
    }
}

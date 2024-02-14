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
    }
}

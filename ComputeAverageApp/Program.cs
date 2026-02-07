using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double g1, g2, g3, g4, g5;
            double sum, ave, rounded;

            Console.WriteLine("Enter 5 grades seperated by new line: ");

            g1 = Convert.ToDouble(Console.ReadLine());
            g2 = Convert.ToDouble(Console.ReadLine());
            g3 = Convert.ToDouble(Console.ReadLine());
            g4 = Convert.ToDouble(Console.ReadLine());
            g5 = Convert.ToDouble(Console.ReadLine());

            sum = g1 + g2 + g3 + g4 + g5;
            ave = sum / 5;

            rounded = Math.Round(ave);

            Console.WriteLine("The average is " + ave + " and round off to: " + rounded);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
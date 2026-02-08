using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            int firstnumber = 10;
            int secondnumber = 7;
            double exponent = 7;
            double negatsnumber = -10.7;
            double decinumber = 10.7;

            int sum = firstnumber + secondnumber;
            double absoluteValue = Math.Abs(negatsnumber);
            double power = Math.Pow(firstnumber, secondnumber);
            double squareRoot = Math.Sqrt(firstnumber);
            double roundedNumber = Math.Round(decinumber);
            double ceilingNumber = Math.Ceiling(decinumber);

            Console.WriteLine("Math Program");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Absolute Value: " + absoluteValue);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Square Root: " + squareRoot);
            Console.WriteLine("Rounded Number: " + roundedNumber);
            Console.WriteLine("Ceiling Number: " + ceilingNumber);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

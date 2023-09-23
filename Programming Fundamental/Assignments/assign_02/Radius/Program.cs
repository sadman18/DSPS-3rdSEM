using System;
//Read in the area of a circle, and calculate the radius using this formula r = √(A / π). Round the radius to 2 digits.
namespace Radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rad = Console.ReadLine();
            const double PI = 3.1415;

            if (double.TryParse(rad, out double r))
            {
                double radius = r * r * PI;
                radius = Math.Round(radius, 2);
                Console.WriteLine($"Radius of a circle : {radius}");
            }
            else
            {
                Console.WriteLine("enter a number for radius");
            }


            
        }
    }
}

using System;
//Read in length and width of a rectangle and calculate its circumference by the formula 2*(l + w).
namespace Circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string length = Console.ReadLine();
            string width = Console.ReadLine();
            

            double l = double.Parse(length);
            double w = double.Parse(width);

            double circumference = 2 * (l + w);

            Console.WriteLine(circumference);

        }
    }
}

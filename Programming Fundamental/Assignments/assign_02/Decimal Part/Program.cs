using System;
using System.Threading.Channels;
//Read in a number and print out the decimal part of the number (round to 6 digits).
namespace Decimal_Part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string DecimalPart="";

            if (double.TryParse(input, out double number))
            {
                DecimalPart = (number % 1).ToString("F6");

            }
            else 
            {
                Console.WriteLine("write a decimal number");
            }
            Console.WriteLine(DecimalPart);

        }
    }
}

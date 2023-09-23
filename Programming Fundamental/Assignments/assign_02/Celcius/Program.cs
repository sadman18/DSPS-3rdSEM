using System;
//Read in a number as degrees Celsius and convert it to degrees Kelvin and degrees Fahrenheit with these formulas:
//Kelvin = C + 273 and Fahrenheit = C x 18 / 10 + 32. Round degrees to 3 digits.
namespace Celcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();

            if (float.TryParse(temp, out float C))
            {
                float Fahrenheit = C * 18 / 10 + 32;
                float Kelvin = C + 273;

                Console.WriteLine(Kelvin);
                Console.WriteLine(Fahrenheit);
            }
        }
    }
}

using System;
//Read in minutes and convert it to seconds and hours.

namespace Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string minutes = Console.ReadLine();

            if (int.TryParse(minutes, out int minute))
            {
                int seconds = minute * 60;
                int hours = minute / 60;
                Console.WriteLine($"{seconds}\n{hours}");
            }
        }
    }
}

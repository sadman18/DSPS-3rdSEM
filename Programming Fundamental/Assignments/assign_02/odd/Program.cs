using System;
//Read in an integer.Print true if the number is odd, otherwise print false.

namespace odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool cond = false;  
            if (int.TryParse(input, out int number))
            {
                if (number%2 != 0)
                {
                    cond = true;
                    Console.WriteLine(cond);
                }
                else
                {
                    Console.WriteLine(cond);
                }
            }
            else
            {
                Console.WriteLine("enter a number");
            }
        }
    }
}

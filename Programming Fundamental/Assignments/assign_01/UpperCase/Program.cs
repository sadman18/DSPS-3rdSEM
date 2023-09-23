using System;
//Read the name of a person and print the name in uppercase characters
namespace UpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine($"HELLO { name }");
        }
    }
}

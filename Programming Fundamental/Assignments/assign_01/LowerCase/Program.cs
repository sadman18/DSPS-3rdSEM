using System;
//Read a person's name and favorite animal and print '<name>, your favorite animal is <animal>'. Make sure the animal is printed in lowercase

namespace LowerCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string animal = Console.ReadLine().ToLower();
            Console.WriteLine($"{name}, your favorite animal is {animal}");
        }
    }
}

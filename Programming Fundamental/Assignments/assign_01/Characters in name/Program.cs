using System;

//Read the first name and last name of a person and print '<first name> <last name>,
//your first name has <number> characters and your last name has <numbers>
namespace Characters_in_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int firstLength = firstName.Length;
            int lastLength = lastName.Length;
            Console.WriteLine($"{firstName} {lastName}, your first name has {firstLength} characters and your last name has {lastLength}"); 
        }
    }
}

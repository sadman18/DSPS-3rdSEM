using System;
//Read the name and surname of a person and say 'Hello' to them.
namespace Hello_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine("What's your first name? ");  
            Console.WriteLine("What's your last name? ");  
            Console.WriteLine($"Hello {firstName} {lastName}");
        }
    }
}

using System;
//Read a person's name, trim all spaces and print 'Nice to meet you <name>' on two lines.
namespace Nice_to_meet_you
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().Trim();
            Console.WriteLine($"Nice to meet you\n{name}");
        }
    }
}

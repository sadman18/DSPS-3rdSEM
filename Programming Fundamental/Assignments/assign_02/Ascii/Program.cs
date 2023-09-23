using System;
//Read in a number and convert that number, according to the ASCII table, to the corresponding character. 
//Print out the lower- and uppercase version of that character
namespace Ascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int integer = int.Parse(input);
            char C = (char)integer;
            Console.WriteLine(C);

            char lower = char.ToLower(C);
            char upper = char.ToUpper(C);

            if (C == lower)
            {
                Console.WriteLine(upper);
            }
            else
            {
                Console.WriteLine(lower);
            }
            
        }
    }
}

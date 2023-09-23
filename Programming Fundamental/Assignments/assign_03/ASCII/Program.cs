using System;
//Read in a number and check if the corresponding ASCII character is an alfa character (a-z, A-Z).
//If so, print out the alfa character, if not print closest (in ASCII table) alfa character.
namespace ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            char C = 'x' ;
            if ((input >= 'A' && input <= 'Z') || (input >= 'a' && input <= 'z') )
            {
                C = (char)input;

            } //(65 to 90) A-Z && (97 to 122) a-z
            else
            {
                if (input < 'A')
                {
                    C = 'A';
                }
                else if (input > 'z')
                {
                    C = 'z';
                }
                else
                {
                   C = (input - 'Z' < 'a' - input) ? 'Z' : 'a';
                }
                
            }
            Console.WriteLine(C);


        }
    }
}

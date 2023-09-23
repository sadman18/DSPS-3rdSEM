using System;
using System.Security.Cryptography.X509Certificates;
//Read in two integers, a and b, print true if a can be divided evenly by b. print false otherwise.
namespace Divide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int a = int.Parse(input1);
            int b = int.Parse(input2);

            bool condition = false;

            if (a%b == 0)
            {
                condition = true;
                Console.WriteLine(condition);
            }
            else
            {
                Console.WriteLine(condition);
            }
           
        }
    }
}

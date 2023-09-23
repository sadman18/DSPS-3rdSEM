using System;
using System.Threading.Channels;
//Read in three characters and display them in reverse order. t a c  cat
namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine(); 
            string b = Console.ReadLine(); 
            string c = Console.ReadLine();
            string temp;

            temp = a;
            a = c;
            c = temp;

            Console.WriteLine($"{a}{b}{c}");


        }
    }
}

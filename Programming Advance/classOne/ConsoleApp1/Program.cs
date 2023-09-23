using ConsoleApp1;
using System;

namespace class_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"), Int32.Parse);

            Searching Searching = new Searching();

            int number = 45;
            Console.WriteLine($"linear : {number} {Searching.Linear(array,number)}- count : {Searching.count}");
            Console.WriteLine($"Stupid : {number} {Searching.Stupid(array,number)}- count : {Searching.count}");
            Console.WriteLine($"Binary : {number} {Searching.binary(array,number)}- count : {Searching.count}");

        }
    }
}

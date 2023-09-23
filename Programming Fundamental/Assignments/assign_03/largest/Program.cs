using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
//Read in three numbers and print the largest one
namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());    
            int num2 = Convert.ToInt32(Console.ReadLine());    
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;
            if (num2>max)
            {
                max = num2;
            }
            if ( num3 > num2 ) 
            {
                max = num3;
            }


            int min = num3;
            if (num2<min)
            {
                min = num2;
            }
            if (num1<min) 
            {
                min = num1;
            }

            Console.WriteLine("\n"+ max);
            Console.WriteLine("\n"+ min);


        }
    }
}

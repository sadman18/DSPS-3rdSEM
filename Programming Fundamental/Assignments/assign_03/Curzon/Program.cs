//using System;
////Read in a non-negative integer (print out 'crazy input' if the input is not given correctly) and check if it is a Curzon Number.
////A Curzon number is a number N where 2^N + 1 is divisible by 2*N + 1. 
//namespace Curzon
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double n = double.Parse(Console.ReadLine());
//            double condition1 = (2 * n) + 1;
//            double condition2 = (Math.Pow(2,n))+1 ;
//            double curzon = 0;
//            string condition;

//            if (condition2%condition1==0)
//            {
//                curzon = (condition2 % condition1);
//                condition = "true";
//            }
//            else
//            {
//                condition = ("crazy input");
//            }
//            Console.WriteLine(condition1);
//            Console.WriteLine(condition2);
//            Console.WriteLine(condition);
//        }
//    }
//}

using System;

namespace Curzon
{
    class Program
    {
        private static object trypase;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number1;
            bool success = Int32.TryParse(input, out number1);

            double number2 = (Math.Pow(2, number1)) + 1;
            double number3 = ((2 * number1) + 1);
            double number4 = number2 % number3;

            if (success)
            {
                if (number1 > 0)
                {
                    if (number4 == 0)
                    {
                        Console.WriteLine("TRUE");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }

        }
    }
}

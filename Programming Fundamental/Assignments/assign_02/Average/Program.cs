//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter numbers (press 'p' to stop):");

//        int sum = 0;
//        int count = 0;
//        string input;
//        while (true)
//        {
//            input = Console.ReadLine();

//            if (input.ToLower() == "p")
//                break;

//            if (int.TryParse(input, out int number))
//            {
//                sum += number;
//                count++;
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter a number or 'p' to stop.");
//            }
//        }

//        if (count > 0)
//        {
//            double average = (double)sum / count;
//            Console.WriteLine($"Average: {average:F2}");
//        }
//        else
//        {
//            Console.WriteLine("No numbers entered.");
//        }

//        Console.WriteLine("Program stopped.");
//    }
//}

using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers (press 'p' to stop):");
        double sum = 0;
        int count = 0;
        string input;
        double average = 1;
        while (true)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "p")
            {
                break;
            }
            else
            {
                if (double.TryParse(input, out double number))
                {
                    sum += number;
                    count++;

                }
                else
                {
                    Console.WriteLine("enter 'p' to stop");
                }
            }
        }
            if (count>0)
            {
                 average = sum / count;
            }
            Console.WriteLine($"average : {average}");
            
        

    }
}
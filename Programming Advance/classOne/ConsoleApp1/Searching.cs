using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Searching
    {
        public int count { get; set; }
        public int Linear(int[] array,int number)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                if (array[i]==number)
                {
                    return i;
                }
            }
            return -1;

        }

        public int Stupid(int[] array,int number)
        {
            int count = 0;
            int max_count = array.Length * 2;

            Random random = new Random();
            while (count < max_count)
            {

                int index = random.Next(0, array.Length);
                count++;
                if (array[index] == number)
                {
                    
                    return index;
                }
                
            }
            return -1;
        }
        public int binary(int[] array,int number)
        {
            count = 0;
            int start = 0;
            int end = array.Length-1;
            while (start <= end)
            {
                count++;
                int mid = (start + end) / 2;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (number < array[mid])
                {
                    end = mid - 1;
                }
                
                else
                {
                    start = mid + 1;
                }
            }
            return -1;


        }
    }
}

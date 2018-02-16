using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArraysSorting
    {
        static void Main(string[] args)
        {
            // input numbers
            int[] nums = new int[7];
            Console.WriteLine("Please enter 7 numbers");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"#{i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
                    
            //// sort
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}

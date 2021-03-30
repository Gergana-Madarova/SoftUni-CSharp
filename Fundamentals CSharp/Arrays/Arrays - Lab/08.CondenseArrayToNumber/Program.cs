using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = nums.Length;

            while (length != 1)
            {
                int[] condensed = new int[length - 1];

                for (int i = 0; i < length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                
                for (int i = 0; i < length-1; i++)
                {
                    nums[i] = condensed[i];                    
                }

                nums[length-1] = 0;
                length -= 1;
            }

            Console.WriteLine(nums[0]);
        }
    }
}

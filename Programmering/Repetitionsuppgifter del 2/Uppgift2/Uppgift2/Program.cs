using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[Convert.ToInt32(Console.ReadLine())];

            for(int i = 0; i < nums.Length; i++) nums[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nums.Length; i++) Console.WriteLine($"Sqrt root of {nums[i]} is {Math.Sqrt(nums[i])}");

        }
    }
}

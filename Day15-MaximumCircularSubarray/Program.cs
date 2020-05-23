using System;
using System.Collections.Generic;

namespace Day15_MaximumCircularSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> intList = new List<int[]>();
            intList.Add(new int[] { 1, -2, 3, -2 }); //output 3
            intList.Add(new int[] { 5, -3, 5 }); //output 10
            intList.Add(new int[] { 3, -1, 2, -1 }); //output 4
            Solution s = new Solution();

            foreach (int[] nums in intList)
            {
                int result = s.MaxSubarraySumCircular(nums);
                Console.WriteLine(nums.ToString() + "Result: " + result);
            }


            Console.WriteLine("Hello World!");
        }

    }

    // need to research Kadane's algorithm
    // referenced this one: https://leetcode.com/problems/maximum-sum-circular-subarray/discuss/633987/C-O(n)
    public class Solution
    {
        public int MaxSubarraySumCircular(int[] A)
        {


            int maxSum = Int32.MinValue, currMax = 0;
            int minSum = Int32.MaxValue, currMin = 0;
            int sum = 0;

            foreach (int num in A)
            {
                currMax = Math.Max(currMax + num, num);
                maxSum = Math.Max(maxSum, currMax);

                currMin = Math.Min(currMin + num, num);
                minSum = Math.Min(minSum, currMin);

                sum += num;
            }

            return maxSum > 0 ? Math.Max(maxSum, sum - minSum) : maxSum;
        }
    }
}

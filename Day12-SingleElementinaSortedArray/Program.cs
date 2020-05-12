using System;
using System.Collections.Generic;

namespace Day12_SingleElementinaSortedArray
{
    // sorted array, where we need to find a duplicate
    // want to do O(log N) thinking Binary Search
    // got a bit help here but he described it very well : https://www.youtube.com/watch?v=4Gi8uAz666s
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> intList = new List<int[]>();
            intList.Add(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 });
            intList.Add(new int[] { 3, 3, 7, 7, 10, 11, 11 });
            intList.Add(new int[] { 3 });
            Solution s = new Solution();

            foreach (int[] nums in intList)
            {
                int result = s.SingleNonDuplicate(nums);
                Console.WriteLine(nums.ToString() + "Result: " + result);
            }


            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2; //helps with overflow for large numbers

                bool isEven = (right - mid) % 2 == 0;
                if (nums[mid] == nums[mid - 1])
                {
                    if (isEven)
                    {
                        right = mid - 2;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if (nums[mid] == nums[mid + 1])
                {
                    if (isEven)
                    {
                        left = mid + 2;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    //return early if left and right are different
                    return nums[mid];
                }
            }
            return nums[left];
        }
    }

}

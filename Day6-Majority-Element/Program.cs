using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6_Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int result = s.MajorityElement(new int[] { 3, 2, 3 });
            result = s.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            Console.WriteLine("Result: " + result);
        }
    }

    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            SortedDictionary<int, int> sortedD = new SortedDictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (sortedD.ContainsKey(nums[i]))
                {
                    sortedD[nums[i]] += 1;
                }
                else
                {
                    sortedD.Add(nums[i], 1);
                }
            }
            //linq magic
            var max = sortedD.OrderByDescending(d => d.Value).First();
            int key = max.Key;
            return key;

        }
    }
}

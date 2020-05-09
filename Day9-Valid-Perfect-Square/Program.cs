using System;
using System.Collections.Generic;

namespace Day9_Valid_Perfect_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test1 = new List<int>();
            test1.Add(16); //return true
            test1.Add(14); //return false
            test1.Add(25); //return true
            test1.Add(22); //return false;
            test1.Add(1); //return true;
            test1.Add(2147483647); //large number

            Solution s = new Solution();

            foreach (int test in test1)
            {
                bool result = s.IsPerfectSquare(test);
                Console.WriteLine("Test: " + test + " Result = " + result.ToString());
            }

        }
    }
    // simple binary search
    // O(log n)
    
    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
         if (num < 1) return false;
         long low = 0;
         long high = num;
         while (low <= high){
             long mid = (low + high) / 2 ;
             long square = mid * mid;
             if (square == num) return true;
             if (square < num) low = mid + 1;
             else high = mid - 1;
         }  
         return false;
        }
    }
}

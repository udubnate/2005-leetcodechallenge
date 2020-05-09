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

    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                double eval = (double)num / i;
                if (eval == i)
                {
                    return true;
                }
                //trying to speed things up a bit
                if (i > (num / 2)) break;

            }
            return false;
        }
    }
}

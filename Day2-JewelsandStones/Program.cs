using System;
using System.Collections.Generic;

namespace Day2_JewelsandStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int result = s.NumJewelsInStones("aA", "aAAbbbb");

            Console.WriteLine("Output: " + result);
        }
    }

    public class Solution
    {
        // note: did O(n^2) - may refactor add some point and do O(n)
        // O(n) - add to hashset, use hashset contains for get check
        
        public int NumJewelsInStones(string J, string S)
        {

            int count = 0;

            //loop through long string
            for (int i = 0; i < S.Length; i++)
            {
                //long through small string for matches
                for (int j = 0; j < J.Length; j++)
                {

                    if (J[j] == S[i])
                    {
                        // found
                        count++;
                    }
                }

            }
            return count;
        }
    }
}

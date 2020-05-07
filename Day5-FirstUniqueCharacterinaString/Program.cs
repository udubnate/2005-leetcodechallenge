using System;
using System.Collections.Generic;

namespace Day5_FirstUniqueCharacterinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "loveleetcode";
            str = "dddccdbba"; //returns 8
            Solution s = new Solution();
            int result = s.FirstUniqChar(str);

            Console.WriteLine("Result: " + result);
        }
    }

    public class Solution
    {
        public int FirstUniqChar(string s)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }
            int count = 0;

            foreach (KeyValuePair<char, int> kvp in dict)
            {
                if (kvp.Value == 1)
                {
                    return s.IndexOf(kvp.Key);
                }
                count++;
            }
            return -1;

        }
    }
}

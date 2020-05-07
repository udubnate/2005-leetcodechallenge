using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3_Ransom_Note
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            List<bool> blist = new List<bool>();

            bool s1 = s.CanConstruct("a", "b");
            blist.Add(s1);
            bool s2 = s.CanConstruct("aa", "ab");
            blist.Add(s2);
            bool s3 = s.CanConstruct("aa", "aab");
            blist.Add(s3);

            foreach (bool b in blist)
            {
                Console.WriteLine("test: " + b + "\n");
            }

        }
    }

    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            List<char> ransomLetters = new List<char>();
            ransomLetters = ransomNote.ToList();

            for (int i = 0; i < magazine.Length; i++)
            {
                for (int j = 0; j < ransomLetters.Count; j++)
                {
                    if (magazine[i] == ransomLetters[j])
                    {
                        ransomLetters.Remove(ransomLetters[j]);
                    }
                }
            }
            return ransomLetters.Count == 0 ? true : false;
        }

    }
}
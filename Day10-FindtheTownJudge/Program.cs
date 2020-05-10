using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day10_FindtheTownJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inputlist = new Dictionary<string, int>();
            inputlist.Add("[[1,2]]", 2); //should return 2
            inputlist.Add("[[1,3],[2,3]]", 3); //should return 3
            inputlist.Add("[[1,3],[2,3],[3,1]]", 3); //should return -1
            inputlist.Add("[[1,2],[2,3]]", 3); //should return -1
            inputlist.Add("[[1,3],[1,4],[2,3],[2,4],[4,3]]", 4); //should return 3
            inputlist.Add("[]", 1); //should return 1;

            int n = 3;
            Solution s = new Solution();

            foreach (KeyValuePair<string, int> kvp in inputlist)
            {
                string pat = @"\d{1},\d{1}";
                Regex r = new Regex(pat);
                MatchCollection matches = r.Matches(kvp.Key);
                //declare jagged array
                int[][] jagged = new int[matches.Count][];
                for (int i = 0; i < matches.Count; i++)
                {
                    string[] point = matches[i].Value.Split(',');
                    jagged[i] = new int[2];
                    jagged[i][0] = Int32.Parse(point[0]);
                    jagged[i][1] = Int32.Parse(point[1]);
                }

                int result = s.FindJudge(kvp.Value, jagged);
                Console.WriteLine("String: " + kvp.Key + " N: " + kvp.Value + " output: " + result);
            }

        }
    }

    public class Solution
    {
        public int FindJudge(int N, int[][] trust)
        {
            if (N == 1) return 1;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> trusters = new Dictionary<int, int>();

            for (int i = 0; i < trust.Length; i++)
            {
                if (dict.ContainsKey(trust[i][1]))
                {
                    dict[trust[i][1]] += 1;
                }
                else
                {
                    dict.Add(trust[i][1], 1);
                }

                if (trusters.ContainsKey(trust[i][0]))
                {
                    trusters[trust[i][0]] += 1;
                }
                else
                {
                    trusters.Add(trust[i][0], 1);
                }
                

            }

            foreach (KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Value == N - 1)
                {
                    //checks if the Town Judge is trusting someone else
                    if (trusters.ContainsKey(kvp.Key))
                    {
                        return -1;
                    }
                    else
                    {
                        return kvp.Key;
                    }



                }
            }
            return -1;
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Day8_CheckIfItIsaStraightLine
{
    class Program
    {

        // reference: https://www.dotnetperls.com/jagged-array
        static void Main(string[] args)
        {

            string str = "[[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]"; //should return true
            //string str = "[[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]"; //should return false
            string pat = @"\d{1},\d{1}";
            Regex r = new Regex(pat);
            MatchCollection matches = r.Matches(str);
            //declare jagged array
            int[][] jagged = new int[matches.Count][];
            for (int i = 0; i < matches.Count; i++)
            {
                string[] point = matches[i].Value.Split(',');
                jagged[i] = new int[2];
                jagged[i][0] = Int32.Parse(point[0]);
                jagged[i][1] = Int32.Parse(point[1]);
            }

            Solution s = new Solution();
            bool result = s.CheckStraightLine(jagged);

            Console.WriteLine("Result: " + result);
        }
    }


    public class Solution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            double lastdydx = -1;

            for (int i = coordinates.Length - 1; i > 0; i--)
            {

                double dydx = (double)(coordinates[i][1] - coordinates[i - 1][1]) / (coordinates[i][0] - coordinates[i - 1][0]);

                if (lastdydx == -1)
                {
                    lastdydx = dydx;
                    continue;
                }
                if (lastdydx != dydx)
                {
                    return false;
                }
                else
                {
                    lastdydx = dydx;
                }


            }
            return true;
        }
    }
}



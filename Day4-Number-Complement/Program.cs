using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4_Number_Complement
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;
            Solution s = new Solution();
            int result = s.FindComplement(n);

            Console.WriteLine("Result : " + result);
        }
    }

    public class Solution
    {
        public int FindComplement(int num)
        {
            string binary = Convert.ToString(num, 2);
            char[] result = binary.Select(x => x == '1' ? '0' : (x == '0' ? '1' : x)).ToArray();
            string compstr = new string(result);
            int compbinary = Convert.ToInt32(compstr, 2);
            return compbinary;
        }
    }
}

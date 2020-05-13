using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day13_RemoveKDigits
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, int> numList = new Dictionary<string, int>();
            numList.Add("1432219", 3); //expected 1219
            numList.Add("10200", 1);
            numList.Add("10", 2);
            numList.Add("9", 1); // expect 0
            numList.Add("112", 1);
            numList.Add("1234567890", 9); //expect 0
            Solution s = new Solution();

            foreach (KeyValuePair<string, int> kvp in numList)
            {
                string result = s.RemoveKdigits(kvp.Key, kvp.Value);
                Console.WriteLine(kvp.Key + " - " + kvp.Value + " = " + result);
            }
            Console.WriteLine("Hello World!");
        }
    }
    //check previous number to see if it greater than current number
    // got some help from here https://www.youtube.com/watch?v=vbM41Zql228

    public class Solution
    {
        public string RemoveKdigits(string num, int k)
        {

            Stack<int> stack = new Stack<int>();
            int size = num.Length;
            int counter = 0;
            while (counter < size)
            {
                int curval = Int32.Parse(num[counter].ToString());

                while (k > 0 && stack.Count != 0 && stack.Peek() > curval)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(curval);
                counter++;
            }

            while (k > 0)
            {
                stack.Pop();
                k--;
            }

            StringBuilder sb = new StringBuilder();

            while (stack.Count != 0)
            {
                char current_char = Convert.ToChar(stack.Pop() + 48);
                sb.Append(current_char);
            }
            //reverse string builder
            for (int i = 0; i < sb.Length / 2; i++)
            {
                var temp = sb[sb.Length - i - 1];
                sb[sb.Length - i - 1] = sb[i];
                sb[i] = temp;
            }
            //remove first element if 0
            while (sb.Length > 1 && sb[0] == '0')
            {
                sb.Remove(0, 1);
            }

            //special case
            if (sb.ToString() == "") return "0";

            return sb.ToString();
        }
    }
}

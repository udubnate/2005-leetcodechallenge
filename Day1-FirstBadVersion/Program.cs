using System;

namespace Day1_FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int output = s.FirstBadVersion(100);
            
            Console.WriteLine("Result: " + output.ToString());
        }
    }
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution {
    public int FirstBadVersion(int n) {

        var left = 1;
        var right = n;

        while (left < right) {
            var mid = left + (right - left) / 2;
            if (IsBadVersion(mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left;
    }

    bool IsBadVersion(int version) {
        if (version >= 10){
            return true;
        } else {
        return false;
        }
    }
}


}

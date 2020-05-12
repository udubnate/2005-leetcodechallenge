using System;

namespace Day11_FloudFill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

// solution took from https://leetcode.com/problems/flood-fill/discuss/626272/C-recursion-solution
// didn't have time but wanted to submit a recursion one and analysis it
    public class Solution {
     public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        var oldColor = image[sr][sc];
        var rowMax = image.Length - 1;
        var colMax = image[0].Length - 1;

        if(oldColor != newColor) Fill(sr, sc);
        return image;

        void Fill(int row, int col) {
            if(row < 0 || rowMax < row ||
               col < 0 || colMax < col ||
               image[row][col] != oldColor) return;

            image[row][col] = newColor;

            Fill(row - 1, col);
            Fill(row + 1, col);
            Fill(row, col - 1);
            Fill(row, col + 1);
        }
    }
}

}

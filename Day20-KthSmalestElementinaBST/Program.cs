using System;

namespace Day20_KthSmalestElementinaBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // leveraged this code today: https://leetcode.com/problems/kth-smallest-element-in-a-bst/discuss/63955/A-C-Inorder-recursive-solution
    class Solution
    {
        // By mocking up StefanPochmann's C++ solution.
        // https://leetcode.com/discuss/43267/4-lines-in-c
        public int KthSmallest(TreeNode root, int k)
        {
            return helper(root, ref k);
        }

        int helper(TreeNode root, ref int k)
        {
            if (root == null) return 0;
            int x = helper(root.left, ref k);
            return k == 0 ? x : --k == 0 ? root.val : helper(root.right, ref k);
        }
    }
}


//Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

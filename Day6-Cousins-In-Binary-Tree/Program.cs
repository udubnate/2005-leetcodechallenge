using System;

namespace Day6_Cousins_In_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            // TreeNode t = new TreeNode(new int?[]{1,2,3,4}, 0);
            // bool result = s.IsCousins(t, 4, 3); // expected false

            // TreeNode t = new TreeNode(new int?[]{1,2,3,null,4,null,5}, 0);
            // bool result = s.IsCousins(t, 5, 4); //expected true

            // TreeNode t = new TreeNode(new int?[]{1,2,3,null,4}, 0);
            // bool result = s.IsCousins(t, 2, 3); //expected false

            TreeNode t = new TreeNode(new int?[]{1,null,2,3,null,null,4,null,5}, 0);
            bool result = s.IsCousins(t, 1, 3); //expected false
            Console.WriteLine("Result: " + result.ToString());
        }
    }


// really like how easy to read this C# solution is - https://leetcode.com/problems/cousins-in-binary-tree/discuss/243807/Easy-C-Solution
public class Solution
{
    TreeNode p1;
    TreeNode p2;
    int l1;
    int l2;
    public bool IsCousins(TreeNode root, int x, int y) 
    {
        if (root == null || root.val == x || root.val == y) return false;
        
        Find(root.left, root, 0, x, y);
        Find (root.right, root, 0, x, y);
        
        return (l1 == l2) && (p1.val != p2.val);
    }
    
    public void Find(TreeNode root, TreeNode parent, int level, int x, int y)
    {
        if (root == null) return;
        
        if (root.val == x)
        {
            p1 = parent;
            l1 = level;
        }
        else if (root.val == y)
        {
            p2 = parent;
            l2 = level;
        }
        
        Find(root.left, root, level + 1, x, y);
        Find(root.right, root, level + 1, x, y);
    }
}


    public class TreeNode
    {
        public int? val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int?[] values, int index)
        {
        Load(this, values, index);
        }

        public void Load(TreeNode tree, int?[] values, int index)
        {
            this.val = values[index];
            if (index * 2 + 1 < values.Length)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }
    }


}

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

    public class Solution
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            TreeNode parentx = getParent(root, x);
            TreeNode parenty = getParent(root, y);
            if (parentx == parenty) return false;

            int levelx = getLevel(root, x, 1);
            int levely = getLevel(root, y, 1);

            return levelx == levely ? true : false;

        }

        public int getLevel(TreeNode root, int elem, int level){
            
            if (root == null){
                return 0;
            }
            if (root.val == elem) {
                return level;
            }
             int downlevel = getLevel(root.left, elem, level + 1);
             if (downlevel != 0){
                 return downlevel;
             }

             downlevel = getLevel(root.right, elem, level + 1);
             
             return downlevel;
           
            
        }

        TreeNode getParent(TreeNode root, int n){
            if (root.left == null && root.right == null){
                return null;
            }

            if (root.right != null){
                if (root.right.val == n){
                    return root;
                }
            }

            if (root.left != null){
                if (root.left.val == n){
                    return root;
                }
            }

            if (root.left != null){
                TreeNode leftnode = getParent(root.left, n);
                if (leftnode != null){
                    return leftnode;
                }
            }

            return getParent(root.right, n);
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

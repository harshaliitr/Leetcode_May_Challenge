using System;
using System.Collections.Generic;

namespace Leetcode_May_Challenge.Week1
{
    public class CousinsInBinaryTree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            return ((Level(root, x, 1) == Level(root, y, 1)) &&
                (!IsSibling(root, x, y)));
        }
        private bool IsSibling(TreeNode node, int a, int b)
        {
            if (node == null)
            {
                return false;
            }

            return ((node.left?.val == a && node.right?.val == b) ||
                (node.left?.val == b && node.right?.val == a) ||
                IsSibling(node.left, a, b) ||
                IsSibling(node.right, a, b));
        }
        private int Level(TreeNode node, int ptr, int lev)
        {
            if (node == null)
            {
                return 0;
            }

            if (node?.val == ptr)
            {
                return lev;
            }

            int l = Level(node.left, ptr, lev + 1);
            if (l != 0)
            {
                return l;
            }

            return Level(node.right, ptr, lev + 1);
        }
    }

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
}

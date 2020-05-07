using System;

namespace Leetcode_May_Challenge.Week1
{
    public class CousinInBinary1
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var xParentAndLevel = ParentAndLevel(root, root, x, 0);
            var yParentAndLevel = ParentAndLevel(root, root, y, 0);

            if (xParentAndLevel.Item2 == yParentAndLevel.Item2 && (xParentAndLevel.Item1 != yParentAndLevel.Item1))
                return true;
            return false;
        }
        private Tuple<int?, int> ParentAndLevel(TreeNode node, TreeNode parentNode, int value, int lev)
        {
            if (parentNode == null)
            {
                return new Tuple<int?, int>(parentNode?.val, 0);
            }

            Tuple<int?, int> temp = new Tuple<int?, int>(parentNode.val, 0);
            if (node?.val == value)
            {
                return new Tuple<int?, int>(parentNode.val, lev);
            }

            if (node?.left != null)
                temp = ParentAndLevel(node?.left, node, value, lev + 1);

            if (temp.Item2 != 0)
                return temp;

            return ParentAndLevel(node?.right, node, value, lev + 1);
        }
    }
}

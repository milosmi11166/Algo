namespace Algo.Trees
{
    public class IsBalanced
    {

        public static bool IsBalancedTree(TreeNode root)
        {
            if(root == null)
            {
                return true;
            }

            var heightLeft = MaxDepth.Depth(root?.left);
            var heightRight = MaxDepth.Depth(root?.right);
            bool thisBalanced = Math.Abs(heightLeft - heightRight) <= 1;
            return thisBalanced && IsBalancedTree(root?.left) && IsBalancedTree(root?.right);
        }
    }
}
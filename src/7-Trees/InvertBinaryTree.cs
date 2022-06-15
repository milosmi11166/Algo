namespace Algo.Trees
{
    public class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode tmp = root?.left;
            root.left = root?.right;
            root.right = tmp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}
namespace Algo.Trees
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static void Print(TreeNode root) {
            if(root == null)
            {
                return;
            }
            Console.WriteLine(root.val + " ");
            Print(root?.left);
            Print(root?.right);
        }
    }
}
namespace Algo.Trees
{
    public static class MaxDepth
    {
        public static int Depth(TreeNode node){
            if(node==null){
                return 0;
            }
            var leftDepth = Depth(node.left);
            var rightDepth = Depth(node.right);
            return 1+Math.Max(leftDepth,rightDepth);
        }
    }
}
namespace Algo.Trees
{
    public class DFS
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Stack<(TreeNode, int)> st = new Stack<(TreeNode, int)>();
            st.Push((root, 1));

            var maxDepth = int.MinValue;
            while (st.Count > 0)
            {
                var item = st.Pop();
                root = item.Item1;
                var currentDepth = item.Item2;

                maxDepth = Math.Max(maxDepth, currentDepth);

                if (root.left != null)
                {
                    st.Push((root.left, currentDepth + 1));
                }

                if (root.right != null)
                {
                    st.Push((root.right, currentDepth + 1));
                }
            }

            return maxDepth;
        }
    }
}
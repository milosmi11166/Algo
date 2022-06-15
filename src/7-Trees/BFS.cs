namespace Algo.Trees
{
    public class BFS
    {
        public static int MaxDepth(TreeNode root){
            if (root == null) return 0;
        
            int depth = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            
            while (queue.Count != 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; ++i)
                {
                    var curr = queue.Dequeue();
                    
                    if (curr.left != null) queue.Enqueue(curr.left);
                    if (curr.right != null) queue.Enqueue(curr.right);   
                }
                depth++;
            }
            return depth;
        }
    }
}
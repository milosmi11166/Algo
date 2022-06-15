namespace Algo.Stack
{
    public class MinStack {
        private Stack<KeyValuePair<int, int>> stack;

        public MinStack() {
            stack = new Stack<KeyValuePair<int, int>>();
        }
        
        public void Push(int val) {
            if(stack.TryPeek(out var peeked)){
                if(val < peeked.Value){
                    stack.Push(new KeyValuePair<int, int>(val, val));
                }
                else{
                    stack.Push(new KeyValuePair<int, int>(val, peeked.Value));
                }
            }else{
                stack.Push(new KeyValuePair<int, int>(val, val));
            }
        }
        
        public void Pop() {
            stack.TryPop(out var popped);
        }
        
        public int Top() {
            if(stack.TryPeek(out var peeked))
                return peeked.Key;
            return default(int);
        }
        
        public int GetMin() {
            if(stack.TryPeek(out var peeked))
                return peeked.Value;
            return default(int);
        }
    }
}
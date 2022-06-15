namespace Algo.LinkedLists
{
    public class ListCycle
    {
        public static bool HasCycle(ListNode head) {
            HashSet<int> listValues = new HashSet<int>();
            while(head != null){
                if(listValues.Contains(head.val)){
                    return true;
                }
                listValues.Add(head.val);
                head = head.next;
            }
            return false;
        }
    }
}
namespace Algo.LinkedLists
{
    public class ReorderList
    {
        public static ListNode ReorderListSolution(ListNode head) {
            ListNode slowPtr = head;
            ListNode fastPtr = head.next;
            int listCount = 1;

            while(fastPtr!=null && fastPtr.next!=null){
                slowPtr = slowPtr.next;
                fastPtr = fastPtr.next.next;
                listCount += 2;
            }

            if(fastPtr != null){
                listCount++;
            }
            
            ListNode secondHalfReverted = ReverseListSolution.ReverseList(slowPtr.next);
            ListNode result = new ListNode(0);
            ListNode tmp = result;
            int i;
            for(i = 0; secondHalfReverted != null; i++){
                if(i%2==0){
                    tmp.next = head;
                    head = head.next;
                }else{
                    tmp.next = secondHalfReverted;
                    secondHalfReverted = secondHalfReverted.next;
                }
                tmp = tmp.next;
            }

            if(listCount % 2 == 1){
                tmp.next = head;
                tmp.next.next = null;
            }

            return result.next;
        }
    }
}
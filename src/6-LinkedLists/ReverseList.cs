namespace Algo.LinkedLists
{
    public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
    }

    public class ReverseListSolution
    {
        public static ListNode ReverseList(ListNode head) {
            ListNode prevNode = null, currentNode = head, nextNode;
            while(currentNode != null){
                nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;  
                currentNode = nextNode; 
            }
            return prevNode;
        }
    }
}
namespace Algo.LinkedLists
{
    public class MergeSortedLists
    {   
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            ListNode start = new ListNode(0);
            ListNode tmp = start;
            while(list1 != null && list2 != null){
                if(list1.val < list2.val){
                    tmp.next = list1;
                    list1 = list1.next;
                }else{
                    tmp.next = list2;
                    list2 = list2.next;
                }
                tmp = tmp.next;
            }
            tmp.next = list1 ?? list2;
            return start.next;
        }
    }
}
using Algo.TwoPointers;
using Algo.SlidingWindow;
using Algo.Stack;
using Algo.BinarySearch;
using Algo.LinkedLists;
using Algo.Trees;

//Console.WriteLine(Palindrome.IsPalindrome("0P"));
//Console.WriteLine(Palindrome.IsPalindrome("A man, a plan, a canal: Panama"));

// var res = TwoSum2.TwoSum(new int[4]{2,7,11,15}, 9);
// var res1 = TwoSum2.TwoSum(new int[3]{2,3,4}, 6);
// var res2 = TwoSum2.TwoSum(new int[4]{-5,0,3,4}, 10);
// foreach (var item in res2)
// {
//     Console.WriteLine(item);
//}

//Console.WriteLine(BuySellStock.MaxProfit(new int[5]{2,4,9,0,9}));

//Console.WriteLine(ValidParentheses.IsValid("{}]"));

/* MinStack obj = new MinStack();
Console.WriteLine(obj.GetMin());
obj.Push(-2);
obj.Push(0);
obj.Push(-3);
obj.GetMin();
obj.Pop();
Console.WriteLine(obj.Top());
Console.WriteLine(obj.GetMin()); */

//Console.WriteLine(SearchMatrix.Search(new int[][]{new int[]{1,3,5,7},new int[]{10,11,16,20},new int[]{23,30,34,60}}, 12));

//Console.WriteLine(SearchMatrix.Search(new int[][]{new int[]{1}}, 0));

/* var list = new ListNode(1);
list.next = new ListNode(2);
list.next.next = new ListNode(3);
list.next.next.next = new ListNode(4);
list.next.next.next.next = new ListNode(5);

var list2 = new ListNode(1);
list2.next = new ListNode(2);
list2.next.next = new ListNode(3);

 

var res = MergeSortedLists.MergeTwoLists(list2, list);
while(res != null)
{
     Console.WriteLine(res.val);
     res = res.next;
} */

/* var list = new ListNode(1);
list.next = new ListNode(2);
list.next.next = new ListNode(3);
list.next.next.next = new ListNode(4);
list.next.next.next.next = new ListNode(5);

var res = ReorderList.ReorderListSolution(list);

while(res != null)
{
     Console.WriteLine(res.val);
     res = res.next;
} */

/* 0
2 4
1 N 3 -1
5 1 N 6 N 8

0 - 0
2 4 - 1
1 3 -1 - 2
5 1 6 8 - 3 */


var root = new TreeNode(0);
root.left = new TreeNode(2);
root.right = new TreeNode(4);
root.left.left = new TreeNode(1);
root.right.left = new TreeNode(3);
root.right.right = new TreeNode(-1);
root.left.left.left = new TreeNode(5);
root.left.left.right = new TreeNode(1);
root.right.left.right = new TreeNode(6);
root.right.right.right = new TreeNode(8);

//PrintTree.Print(root);
//Console.WriteLine(MaxDepth.Depth(root));
//Console.WriteLine(IsBalanced.IsBalancedTree(root));

Console.WriteLine(BFS.MaxDepth(root));
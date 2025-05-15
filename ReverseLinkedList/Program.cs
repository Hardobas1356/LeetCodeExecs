namespace ReverseLinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        ListNode listNode = new ListNode();
        ListNode nodes = CreateNodes([1, 2, 3, 4, 5]);
        Solution.ReverseList(nodes);
    }

    public static ListNode CreateNodes(int[] array)
    {
        ListNode listNode = new ListNode();
        ListNode current = listNode;

        for (int i = 0; i < array.Length; i++)
        {
            current.val = array[i];

            if (i == array.Length - 1)
                break;

            current.next = new ListNode();
            current = current.next;
        }

        return listNode;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class Solution
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;

            ListNode newList = null;
            ListNode current = head;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = newList;
                newList = current;
                current = nextNode;
            }

            return newList;
        }
    }
}

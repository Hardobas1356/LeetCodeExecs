namespace Remove_Duplicates_from_Sorted_List;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    public class Solution
    {
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

        public ListNode DeleteDuplicates(ListNode head)
        {
            if(head == null) return head;   

            ListNode tmp = head;

            while (tmp.next != null)
            {
                if (tmp.val == tmp.next.val)
                {
                    tmp.next = tmp.next.next;
                }
                else
                {
                    tmp = tmp.next;
                }
            }

            return head;
        }
    }
}

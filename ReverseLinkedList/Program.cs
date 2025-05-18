namespace ReverseLinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        ListNode listNode = new ListNode();
        ListNode nodes = CreateNodes([1,2]);

        Solution.RemoveNthFromEnd(nodes, 2);
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

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list2 == null) return list1;
            if (list1 == null) return list2;

            ListNode newList;
            if (list1.val < list2.val)
            {
                newList = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                newList = new ListNode(list2.val);
                list2 = list2.next;
            }

            ListNode current = newList;

            while (list1 != null || list2 != null)
            {

                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        current.next = new ListNode(list1.val);
                        list1 = list1.next;
                    }
                    else
                    {
                        current.next = new ListNode(list2.val);
                        list2 = list2.next;
                    }

                    current = current.next;
                }
                else
                {
                    while (list1 != null)
                    {
                        current.next = new ListNode(list1.val);
                        list1 = list1.next;

                        current = current.next;
                    }

                    while (list2 != null)
                    {
                        current.next = new ListNode(list2.val);
                        list2 = list2.next;

                        current = current.next;
                    }
                }
            }

            return newList;
        }

        public static bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                    return true;
            }

            return false;
        }

        public static ListNode MiddleNode(ListNode head)
        {
            if (head.next == null) return head;

            int count = 0;

            ListNode listNode = head;

            while (head.next != null)
            {
                count++;
                head = head.next;
            }

            count = count / 2 + count % 2;

            while (count > 0)
            {
                listNode = listNode.next;
                count--;
            }

            return listNode;
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;
            int slowCounter = 1;
            int fastCounter = 1;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                fastCounter += 2;
            }

            if (fast.next != null)
            {
                fast = fast.next;
                fastCounter++;
            }

            if (n == fastCounter)
            {
                return head.next;
            }

            int target = fastCounter - n;
            while (slowCounter < target)
            {
                slow = slow.next;
                slowCounter++;
            }

            ListNode swap;
            if (fast == slow)
                swap = null;

            else swap = slow.next.next;
            slow.next = swap;

            return head;
        }
    }
}

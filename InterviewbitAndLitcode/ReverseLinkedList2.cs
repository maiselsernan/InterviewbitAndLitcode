//https://leetcode.com/problems/reverse-linked-list-ii


using System.Xml.Linq;

namespace InterviewbitAndLitcode
{
    public class ReverseLinkedList2
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode currentItem = head;
            ListNode prevItem = null;
            int i = 1;

            while (i < left)
            {
                prevItem = currentItem;
                currentItem = currentItem.Next;
                i++;
            }

            var itemBefore = prevItem;
            var itemStart = currentItem;
            i++;
            prevItem = currentItem;
            currentItem = currentItem.Next;
            ListNode nextItem = null;
            if (currentItem == null)
            {
                return head;
            }

            while (i <= right)
            {
                nextItem = currentItem.Next;
                // here we turn the pointer backwards
                currentItem.Next = prevItem;
                prevItem = currentItem;
                currentItem = nextItem;
                i++;
            }

            // here we relink the head and tail of the inverted sublist
            itemStart.Next = currentItem;
            if (itemBefore != null)
            {
                itemBefore.Next = prevItem;
                return head;
            }
            else
            {
                return prevItem;
            }

        }
      
    }
    public class ListNode
    {
        public ListNode Next { get; set; }
        public int Val { get; set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
}
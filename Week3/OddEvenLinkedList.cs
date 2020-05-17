using System.Collections.Generic;
using System;

namespace Leetcode_May_Challenge.Week3
{
    // 2->1->3->5->6->4->7->Null
    // 2->3->6->7->1->5->4->Null
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenFirst = even;

            while (true)
            {
                if (odd == null || even == null || (even.next) == null)
                {
                    odd.next = evenFirst;
                    break;
                }
                odd.next = even.next;
                odd = even.next;
                if (odd.next == null)
                {
                    even.next = null;
                    odd.next = evenFirst;
                    break;
                }
                even.next = odd.next;
                even = odd.next;
            }
            return head;

        }

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
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewbitAndLitcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class ReverseLinkedList2Tests
    {
        [TestMethod()]
        public void ReverseBetweenTest()
        {
            //arrange
            ReverseLinkedList2 reverseLinkedList2 = new ReverseLinkedList2();
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int left = 2;
            int right = 4;
            ListNode expected = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5)))));

            //act
            ListNode actual = reverseLinkedList2.ReverseBetween(head, left, right);

            //assert
            while (expected != null)
            {
                Assert.AreEqual(expected.Val, actual.Val);
                expected = expected.Next;
                actual = actual.Next;
            }

        }
    }
}
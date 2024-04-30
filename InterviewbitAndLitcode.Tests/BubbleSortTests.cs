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
    public class BubbleSortTests
    {
        [TestMethod()]
        public void BubbleSortMethodTest()
        {
            //arrange
            BubbleSort bubbleSort = new BubbleSort();
            int[] nums = new int[] { 64, 34, 25, 12, 22, 11, 90 };
            int[] expected = new int[] { 11, 12, 22, 25, 34, 64, 90 };

            //act
            bubbleSort.BubbleSortMethod(nums);

            //assert
            CollectionAssert.AreEqual(expected, nums);
        }
    }
}
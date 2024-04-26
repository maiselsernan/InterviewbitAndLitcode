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
    public class BinarySearchTests
    {
        [TestMethod()]
        public void BinarySearchMethodTest()
        {
            //arrange
            BinarySearch binarySearch = new BinarySearch();
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            //act
            int actual = binarySearch.BinarySearchMethod(nums, target);
            //assert
            Assert.AreEqual(2, actual);
        }
    }
}
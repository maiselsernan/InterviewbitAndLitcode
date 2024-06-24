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
    public class JumpGame2Tests
    {
        [TestMethod()]
        public void JumpTest()
        {
            //arrange
            int[] nums = new int[] { 2, 3, 1, 1, 4 };
            JumpGame2 jumpGame2 = new JumpGame2();
            int expected = 2;
            //act
            int actual = jumpGame2.Jump(nums);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
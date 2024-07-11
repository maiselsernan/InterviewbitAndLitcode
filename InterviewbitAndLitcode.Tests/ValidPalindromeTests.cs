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
    public class ValidPalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            //arrange
            ValidPalindrome test = new ValidPalindrome();
            //act
            bool result = test.IsPalindrome("0P");
            //bool result = test.IsPalindrome("A man, a plan, a canal: Panama");
            //assert
            Assert.IsFalse(result);

        }
    }
}
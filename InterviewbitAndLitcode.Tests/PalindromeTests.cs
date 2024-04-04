namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            //arrange
            var palindrome = new Palindrome();
            int x = 121;
            bool expected = true;
            //act
            bool actual = palindrome.IsPalindrome(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsNotPalindromeTest()
        {
            //arrange
            var palindrome = new Palindrome();
            int x = 123;
            bool expected = false;
            //act
            bool actual = palindrome.IsPalindrome(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
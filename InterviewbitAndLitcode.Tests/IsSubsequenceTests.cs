namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class IsSubsequenceTests
    {
        [TestMethod()]
        public void IsSubsequenceMethodTestShouldSucceed()
        {

            //Arrange
            var isSubsequence = new IsSubsequence();
            var s = "abc";
            var t = "ahbgdc";
            var expected = true;
            //Act
            var actual = isSubsequence.IsSubsequenceMethod(s, t);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsSubsequenceMethodTestShouldFail()
        {

            //Arrange
            var isSubsequence = new IsSubsequence();
            var s = "axc";
            var t = "ahbgdc";
            var expected = false;
            //Act
            var actual = isSubsequence.IsSubsequenceMethod(s, t);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        }
}
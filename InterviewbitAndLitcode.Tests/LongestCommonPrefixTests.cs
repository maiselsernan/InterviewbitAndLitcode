namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class LongestCommonPrefixTests
    {
        [TestMethod()]
        public void LongestCommonPrefixMethodTest()
        {
            //Arrange
            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            string[] strs = new string[] { "flower", "flow", "flight" };
            string expected = "fl";
            //Act
            string actual = longestCommonPrefix.LongestCommonPrefixMethod(strs);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
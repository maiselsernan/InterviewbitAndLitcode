namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class IndexOfFirstAccurrenceTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            //arrange
            IndexOfFirstAccurrence test = new IndexOfFirstAccurrence();
            string haystack = "mississippi";
            string needle = "pi";
            int expected = 9;
            //act
            int actual = test.StrStr(haystack, needle);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
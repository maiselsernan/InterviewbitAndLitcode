namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class HIndexTests
    {
        [TestMethod()]
        public void HIndexMethodTest()
        {
            //arrange
            HIndex hIndex = new HIndex();
            int[] citations = new int[] { 3, 0, 6, 1, 5 };
            int expected = 3;
            //act
            int actual = hIndex.HIndexMethod(citations);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
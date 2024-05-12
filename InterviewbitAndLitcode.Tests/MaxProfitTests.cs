namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class MaxProfitTests
    {
        [TestMethod()]
        public void maxProfitTest()
        {
            //arrange
            MaxProfit maxProfit = new MaxProfit();
            int[] prices = new int[] { 3, 2, 6, 5, 0, 3 };
            //int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int expected = 4;
            //int expected = 5;
            //act
            int actual = maxProfit.maxProfit(prices);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class MaxProfit2Tests
    {
        [TestMethod()]
        public void maxProfitTest()
        {
            //arrange
            MaxProfit2 maxProfit2 = new MaxProfit2();
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int expected = 7;
            //act
            int actual = maxProfit2.maxProfit(prices);
            //assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
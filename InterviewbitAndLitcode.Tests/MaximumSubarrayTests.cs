namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class MaximumSubarrayTests
    {
        [TestMethod()]
        public void MaximumSubarrayMethodTest()
        {
            //arrange
            var values = new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int fromIndex;
            int toIndex;
            int total;
            int expectedFromIndex = 3;
            int expectedToIndex = 6;
            int expectedTotal = 6;
            //act
            MaximumSubarray.MaximumSubarrayMethod(values, out fromIndex, out toIndex, out total);
            //assert
            Assert.AreEqual(expectedFromIndex, fromIndex);
            Assert.AreEqual(expectedToIndex, toIndex);
            Assert.AreEqual(expectedTotal, total);
            
        }
    }
}
namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class SearchInRotatedSortedArray2Tests
    {
        [TestMethod()]
        public void SearchTest()
        {
            //arrange
            var searchInRotatedSortedArray2 = new SearchInRotatedSortedArray2();
            var nums = new int[] { 2, 5, 6, 0, 0, 1, 2 };
            //act
            var result = searchInRotatedSortedArray2.Search(nums, 0);
            //assert
            Assert.IsTrue(result);
        }
    }
}
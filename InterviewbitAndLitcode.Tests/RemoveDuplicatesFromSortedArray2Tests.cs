namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class RemoveDuplicatesFromSortedArray2Tests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            //arrange
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var removeDuplicatesFromSortedArray2 = new RemoveDuplicatesFromSortedArray2();
            //act
            int result = removeDuplicatesFromSortedArray2.RemoveDuplicates(nums);
            //assert
            Assert.AreEqual(5, result);
        }
    }
}
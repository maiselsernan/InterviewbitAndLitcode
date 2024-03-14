namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            // Arrange
            var removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
            var nums = new int[] { 1, 1, 2 };

            // Act
            var result = removeDuplicatesFromSortedArray.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(2, result);
            


        }
    }
}
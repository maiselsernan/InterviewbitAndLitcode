namespace InterviewbitAndLitcode.Tests
{
    [TestClass]
    public class MergeSortedArraysTests
    {
        [TestMethod]
        public void Merge_SortedArrays_SuccessfullyMerged()
        {
            // Arrange
            var mergeSortedArray = new MergeSortedArray();
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new int[] { 2, 5, 6 };
            var n = 3;
            var expected = new int[] { 1, 2, 2, 3, 5, 6 };

            // Act
            mergeSortedArray.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }
    }
}
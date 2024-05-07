namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class RotateArrayTests
    {
        [TestMethod()]
        public void RotateArrayMethodTest()
        {
            //arrange
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] nums = new int[] { -1, -100, 3, 99 };
            //int[] nums = new int[] { 1, 2 };
            //int k = 3;
            int k = 2;
            //int[] expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };
            int[] expected = new int[] { 3, 99, -1, -100 };
            //int[] expected = new int[] {2,1 };
            RotateArray rotateArray = new RotateArray();
            //act
            rotateArray.RotateArrayMethod(nums, k);
            //assert
            CollectionAssert.AreEqual(expected, nums);

        }
    }
}
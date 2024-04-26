namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class CanJumpTests
    {
        [TestMethod()]
        public void CanJumpMethodTest()
        {
            //arrange
            CanJump canJump = new CanJump();
            int[] nums = { 2, 3, 1, 1, 4 };
            bool expected = true;
            //act
            bool actual = canJump.CanJumpMethod(nums);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
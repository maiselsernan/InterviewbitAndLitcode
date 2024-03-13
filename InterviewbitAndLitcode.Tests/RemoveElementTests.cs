namespace InterviewbitAndLitcode.Tests
{
    [TestClass]
    public class RemoveElementTests
    {
        [TestMethod]
        public void RemoveElementMethodTest()
        {
            // Arrange
            var removeElement = new RemoveElement();
            var nums = new int[] { 3, 2, 2, 3 };
            var val = 3;
            var expected = 2;

            // Act
            var result = removeElement.RemoveElementMethod(nums, val);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
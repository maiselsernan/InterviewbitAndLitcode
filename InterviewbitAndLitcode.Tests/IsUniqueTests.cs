namespace InterviewbitAndLitcode.Tests
{
    [TestClass()]
    public class IsUniqueTests
    {
        [TestMethod()]
        public void IsUniqueCharsTest()
        {
            //arrange
            IsUnique isUnique = new IsUnique();
            string str = "abc";
            //act
            bool result = isUnique.IsUniqueChars(str);
            //assert
            Assert.IsTrue(result);

        }
    }
}
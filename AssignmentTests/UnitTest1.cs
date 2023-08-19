namespace AssignmentTests
{
    using StringAssignment;

    public class UnitTest1
    {
        [Theory]
        [InlineData("Hello world", "Hello")]
        [InlineData("This is a sentence", "This")]
        [InlineData("", "")]
        public void Test_GetFirstWord(string input, string expected)
        {
            Assert.Equal(expected, Assignments.GetFirstWord(input));
        }

        [Theory]
        [InlineData("Hello world", "world")]
        [InlineData("This is a sentence", "sentence")]
        [InlineData("", "")]
        public void Test_GetLastWord(string input, string expected)
        {
            Assert.Equal(expected, Assignments.GetLastWord(input));
        }

        [Theory]
        [InlineData("Hello my friend, how are you?", "Hello my friend")]
        [InlineData("This is a sentence", "This is a")]
        [InlineData("Only two words", "Only two words")]
        [InlineData("One", "One")]
        [InlineData("", "")]
        public void Test_GetFirstThreeWords(string input, string expected)
        {
            Assert.Equal(expected, Assignments.GetFirstThreeWords(input));
        }

        [Theory]
        [InlineData("Hello my friend, how are you?", "how are you")]
        [InlineData("This is a sentence", "is a sentence")]
        [InlineData("Only two words", "Only two words")]
        [InlineData("One", "One")]
        [InlineData("", "")]
        public void Test_GetLastThreeWords(string input, string expected)
        {
            Assert.Equal(expected, Assignments.GetLastThreeWords(input));
        }

        [Theory]
        [InlineData("Hello World", "HelloWorld")]
        [InlineData("", "")]
        public void Test_RemoveWhiteSpaces(string input, string expected)
        {
            Assert.Equal(expected, Assignments.RemoveWhiteSpaces(input));
        }

        [Theory]
        [InlineData("James John Doe", "John")]
        [InlineData("John Doe", "")]
        [InlineData("Jane", "Jane")]
        [InlineData("", "")]
        public void Test_GetMiddleName(string input, string expected)
        {
            Assert.Equal(expected, Assignments.GetMiddleName(input));
        }

        [Theory]
        [InlineData("Hello,World", "Hello.World")]
        [InlineData("No,Comma,Here", "No.Comma.Here")]
        [InlineData("", "")]
        public void Test_ReplaceCommaWithDot(string input, string expected)
        {
            Assert.Equal(expected, Assignments.ReplaceCommaWithDot(input));
        }
    }
}
using NUnit.Framework;
using hetu.businesslogic;

namespace Tests
{
    public class HetuValidatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnFalseIfEmptyString()
        {
            bool test = HetuValidator.isValidSSN("");

            Assert.IsFalse(test);
        }

        static string[] invalidSSNArray = { "", "1234567890", "1234567890111213141516" };

        [Test]
        [TestCaseSource(nameof(invalidSSNArray))]
        public void ShouldReturnFalseIfNotElevenCharacters(string testCase)
        {
            bool test = HetuValidator.isValidSSN(testCase);

            Assert.IsFalse(test);
        }

        static string[] validSSNArray = { "051084-588X" };

        [Test]
        [TestCaseSource(nameof(validSSNArray))]
        public void ShouldReturnTrueIfElevenCharacters(string testCase)
        {
            bool test = HetuValidator.isValidSSN(testCase);

            Assert.IsTrue(test);
        }

        static string[] nonNumericStartSSNArray = { "abc000-588X" };

        [Test]
        [TestCaseSource(nameof(nonNumericStartSSNArray))]
        public void ShouldReturnFalseIfNonNumericStart(string testCase)
        {
            bool test = HetuValidator.isValidSSN(testCase);

            Assert.IsFalse(test);
        }
    }
}
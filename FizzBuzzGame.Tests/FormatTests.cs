using FizzBuzzGame.WriteStratagy;
using NUnit.Framework;

namespace FizzBuzzGame.Tests
{
    [TestFixture]
    public class FormatTests
    {

        private IFormatLineStratagy _formatLineStratagy;

        [SetUp]
        public void Setup()
        {
            _formatLineStratagy = new FormatLineStratagy();
        }

        [Test]
        public void Format1Return1()
        {
            string result = _formatLineStratagy.FormatLine(1);

            Assert.AreEqual("1", result);
        }

        [Test]
        public void Format3ReturnFizz()
        {
            string result = _formatLineStratagy.FormatLine(3);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void Format5ReturnBuzz()
        {
            string result = _formatLineStratagy.FormatLine(5);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void Format15ReturnFizzBuzz()
        {
            string result = _formatLineStratagy.FormatLine(15);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}

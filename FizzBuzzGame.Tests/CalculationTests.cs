
using FizzBuzzGame.CalcStratagy;
using NUnit.Framework;

namespace FizzBuzzGame.Tests
{
    [TestFixture]
    public class CalculationTests
    {
        private CalculationStratagy _calculationStratagy;
        
        [Test]
        public void DivideByThree_9ReturnsTrue()
        {
            _calculationStratagy = new DivisibleByThreeStratagy();

            Assert.AreEqual(true, _calculationStratagy.CanHandle(9));
        }

        [Test]
        public void DivideByFive_10ReturnsTrue()
        {
            _calculationStratagy = new DivisibleByFiveStratagy();

            Assert.AreEqual(true, _calculationStratagy.CanHandle(10));
        }
    }
}

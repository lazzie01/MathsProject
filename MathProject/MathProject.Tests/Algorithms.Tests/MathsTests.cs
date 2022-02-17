using MathProject.Algorithms;
using NUnit.Framework;

namespace MathProject.Tests.Algorithms.Tests
{
    [TestFixture]
    public class MathsTests
    {
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        public void IsPrime_GivenPrimeNumber_Returns_True(int number)
        {
            //Arrange

            //Act
            var result = Maths.IsPrime(number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestCase(-90)]
        [TestCase(30)]
        [TestCase(50)]
        [TestCase(4)]
        [TestCase(9)]
        public void IsPrime_GivenPrimeNumber_Returns_False(int number)
        {
            //Arrange

            //Act
            var result = Maths.IsPrime(number);

            //Assert
            Assert.IsFalse(result);
        }
    }
}

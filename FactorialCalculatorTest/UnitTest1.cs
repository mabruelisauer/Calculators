using Calculator;

namespace FactorialCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ZeroFactorial()
        {
            //Arrange
            FactorialCalculator calc = new FactorialCalculator();

            //Act
            ulong res = calc.Calculate(0);

            //Assert
            Assert.AreEqual<ulong>(1, res);
        }

        [TestMethod]
        public void OneFactorial()
        {
            //Arrange
            FactorialCalculator calc = new FactorialCalculator();

            //Act
            ulong res = calc.Calculate(1);

            //Assert
            Assert.AreEqual<ulong>(1, res);
        }

        [TestMethod]
        public void TwoFactorial()
        {
            //Arrange
            FactorialCalculator calc = new FactorialCalculator();

            //Act
            ulong res = calc.Calculate(2);

            //Assert
            Assert.AreEqual<ulong>(2, res);
        }

        [TestMethod]
        public void ThreeFactorial()
        {
            //Arrange
            FactorialCalculator calc = new FactorialCalculator();

            //Act
            ulong res = calc.Calculate(3);

            //Assert
            Assert.AreEqual<ulong>(6, res);
        }
    }
}
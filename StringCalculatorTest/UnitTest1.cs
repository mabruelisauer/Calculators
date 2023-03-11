namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicCalculation()
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            int result = calc.Add("5, 6,3");

            //Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void SeperatorN()
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            int result = calc.Add("5, 6\n3");

            //Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void AnySeperator()
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            int result = calc.Add(";1;2");

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NegativeNumbers()
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            string input = (";1;-2;3;-4;5");

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => calc.Add(input), "Negatives not allowed: -2, -4");
        }

        [TestMethod]
        public void NumbersOver1000()
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            int result = calc.Add("2,1001");

            //Assert
            Assert.AreEqual(2, result);
        }
    }
}
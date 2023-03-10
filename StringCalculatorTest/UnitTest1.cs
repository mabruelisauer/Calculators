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
        public void Seperator()
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            int result = calc.Add("5, 6\n3");

            //Assert
            Assert.AreEqual(14, result);
        }
    }
}
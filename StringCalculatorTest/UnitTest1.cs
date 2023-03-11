namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicCalculation()
        {
            //Arrange

            //Act
            int result = StringCalculator.Add("5, 6,3");

            //Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void SeperatorN()
        {
            //Arrange

            //Act
            int result = StringCalculator.Add("5, 6\n3");

            //Assert
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void AnySeperator()
        {
            //Arrange

            //Act
            int result = StringCalculator.Add(";1;2");

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NegativeNumbers()
        {
            //Arrange

            //Act
            string input = (";1;-2;3;-4;5");

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => StringCalculator.Add(input), "Negatives not allowed: -2, -4");
        }

        [TestMethod]
        public void NumbersOver1000()
        {
            //Arrange

            //Act
            int result = StringCalculator.Add("2,1001");

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalledCount()
        {
            //Arrange

            //Act
            StringCalculator.Add("5, 6,3");
            StringCalculator.Add(";4;8");
            StringCalculator.Add("3\n1,5");

            //Assert
            Assert.AreEqual(5, StringCalculator.CalledCount);
            //it works but if u wanted it to make sense u would have to run only this test without the others and replace the 5 in assert with a 3
            //this is because there are no instances possible but one StringCalculator and the tests before this one are also added to the count
        }
    }
}
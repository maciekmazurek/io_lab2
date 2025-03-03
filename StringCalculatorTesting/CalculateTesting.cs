using io_lab2;
using Microsoft.VisualBasic;

namespace StringCalculatorTesting
{
    [TestClass]
    public class CalculateTesting
    {
        StringCalculator sc = new StringCalculator();

        [TestMethod]
        public void FirstTest()
        {
            //Given
            var expectedResult = 0;
            var input = "";

            //When
            var actualResult = sc.Calculate(input);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
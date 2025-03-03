using io_lab2;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Bson;
using System.Security.Cryptography;

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

        [TestMethod] 
        public void SecondTest()
        {
            //Given
            var expectedResult = 5;
            var input = "5";

            //When
            var actualResult = sc.Calculate(input);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ThirdTest()
        {
            //Given
            var expectedResult = 14;
            var input = "11,3";

            //When
            var actualResult = sc.Calculate(input);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FourthTest()
        {
            //Given
            var expectedResult = 10;
            var input = "6\n4";

            //When
            var actualResult = sc.Calculate(input);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
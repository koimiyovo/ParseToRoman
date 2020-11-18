using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseToRoman;

namespace UnitTests
{
    [TestClass]
    public class ParseToRomanTests
    {
        [TestMethod]
        public void ShouldReturnI_IfNumberIs1()
        {
            // Arrange
            int number = 1;
            string expected = "I";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnV_IfNumberIs5()
        {
            // Arrange
            int number = 5;
            string expected = "V";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnIX_IfNumberIs9()
        {
            // Arrange
            int number = 9;
            string expected = "IX";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnX_IfNumberIs10()
        {
            // Arrange
            int number = 10;
            string expected = "X";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnL_IfNumberIs50()
        {
            // Arrange
            int number = 50;
            string expected = "L";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnC_IfNumberIs100()
        {
            // Arrange
            int number = 100;
            string expected = "C";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnD_IfNumberIs500()
        {
            // Arrange
            int number = 500;
            string expected = "D";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnM_IfNumberIs1000()
        {
            // Arrange
            int number = 1000;
            string expected = "M";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnII_IfNumberIs2()
        {
            // Arrange
            int number = 2;
            string expected = "II";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnLV_IfNumberIs55()
        {
            // Arrange
            int number = 55;
            string expected = "LV";

            // Act
            string actual = RomanParser.Parse(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

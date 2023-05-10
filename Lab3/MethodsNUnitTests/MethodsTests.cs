using Moq;
using NumericMethodsLab1;
using System;
using System.IO;
using Xunit;

namespace NumericMethodsLab1
{
    public class MethodsTests
    {
        private Mock<IFileDataService> _fileDataServiceMock;
        private Methods _methods;

        public MethodsTests()
        {
            _fileDataServiceMock = new Mock<IFileDataService>();
            _methods = new Methods(_fileDataServiceMock.Object);
        }

        [Fact]
        public void GetGap_ReturnsExpectedResult()
        {
            // Підготовка
            var expected = (-1.0, 0.5);
           _fileDataServiceMock.Setup(x => x.ReadData()).Returns(expected);

            // Дія
            var result = _methods.GetGap();

            // Перевірка
            Assert.Equal(expected, result);
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.AtLeastOnce); // Перевіряємо, що метод був викликаний принаймні один раз.
        }

        [Fact]
        public void GetGap_ThrowsException_WhenReadDataFails()
        {
            // Підготовка
            _fileDataServiceMock.Setup(x => x.ReadData()).Throws(new IOException());

            // Дія та перевірка
            Xunit.Assert.Throws<IOException>(() => _methods.GetGap());
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.AtLeastOnce);
        }
        [Fact]
        public void GetGap_ThrowsException_WhenReadDataReturnsFalseGap()
        {
            // Підготовка
            var outOfRangeValues = (0.5, -1.0);
            _fileDataServiceMock.Setup(x => x.ReadData()).Returns(outOfRangeValues);

            // Дія та перевірка
            Xunit.Assert.Throws<ArgumentOutOfRangeException>(() => _methods.GetGap());
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.AtLeastOnce);
        }

        

        [Fact]
        public void ReadData_Throws_Exception()
        {
            _fileDataServiceMock.SetupSequence(x => x.ReadData()).Throws(new ArgumentException());

            // Act
            Action act = () => _methods.GetGap(); // Викликаємо метод, який повинен кидати виключення

            // Assert
            Assert.Throws<ArgumentException>(act);
        }


    }
}

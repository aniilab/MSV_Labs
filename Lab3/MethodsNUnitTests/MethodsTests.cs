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
            Xunit.Assert.Equal(expected, result);
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.Once);
        }

        [Fact]
        public void GetGap_ThrowsException_WhenReadDataFails()
        {
            // Підготовка
            _fileDataServiceMock.Setup(x => x.ReadData()).Throws(new IOException());

            // Дія та перевірка
            Xunit.Assert.Throws<IOException>(() => _methods.GetGap());
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.Once);
        }
        [Fact]
        public void GetGap_ThrowsException_WhenReadDataReturnsOutOfRangeValues()
        {
            // Підготовка
            var outOfRangeValues = (-1.0, 2.0);
            _fileDataServiceMock.Setup(x => x.ReadData()).Returns(outOfRangeValues);

            // Дія та перевірка
            Xunit.Assert.Throws<ArgumentOutOfRangeException>(() => _methods.GetGap());
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.Once);
        }

        [Fact]
        public void GetGap_CallsReadData_Once()
        {
            // Arrange
            var expectedData = (0.0, 1.0);
            _fileDataServiceMock.Setup(x => x.ReadData()).Returns(expectedData);

            // Act
            var result = _methods.GetGap();

            // Assert
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.Once); // перевіряємо, що метод ReadData було викликано один раз
        }

        [Fact]
        public void GetGap_CallsReadData_Twice_WhenFirstCallFails()
        {
            // Arrange
            var expectedData = (0.0, 1.0);
            _fileDataServiceMock.SetupSequence(x => x.ReadData())
                .Throws(new IOException())
                .Returns(expectedData);

            // Act
            var result = _methods.GetGap();

            // Assert
            _fileDataServiceMock.Verify(x => x.ReadData(), Times.Exactly(2)); // перевіряємо, що метод ReadData було викликано двічі
        }

        [Fact]
        public void Function_Throws_Exception()
        {
            // Arrange
            var methodsMock = new Mock<IMethods>(MockBehavior.Loose); // створюємо частковий мок
            methodsMock.Setup(m => m.Function(It.IsAny<double>())).Throws(new InvalidOperationException()); // налаштовуємо виключення при виклику Function

            _fileDataServiceMock.Setup(x => x.ReadData()).Returns((0.0, 1.0));

            // Act
            Action act = () => _methods.Dichotomy(0.0, 1.0); // викликаємо метод, який в свою чергу викличе Function

            // Assert
            Xunit.Assert.Throws<InvalidOperationException>(act); // перевіряємо, що було викликано виключення
        }

    }
}

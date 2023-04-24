using System;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;

namespace NumericMethodsLab1.Tests
{
    [TestFixture]
    public class MethodsTests
    {
        private double _a;
        private double _b;
        private double _x0;

        //[OneTimeSetUp]
        //public void BeforeAll()
        //{
            
        //}

        [SetUp]
        public void BeforeEach()
        {
            _a = -1;
            _b = 0.5;
            _x0 = 0.5;
        }

        [Test]
        public void Function_ValidInput_Calculation()
        {
            double x = 1;
            double expectedResult = Math.Pow(x, 3) + 4 * Math.Sin(x);

            double result = Methods.Function(x);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Function_ValidInput_PositiveResult()
        {
            double x = 1;

            double result = Methods.Function(x);

            Assert.IsTrue(result > 0);
        }

        [Test]
        public void FunctionDer_ValidInput_Calculation()
        {
            double x = 1;
            double expectedResult = 3 * Math.Pow(x, 2) + 4 * Math.Cos(x);

            double result = Methods.Function_Der(x);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FunctionDer2_ValidInput_Calculation()
        {
            double x = 1;
            double expectedResult = 6 * x - 4 * Math.Sin(x);

            double result = Methods.Function_Der2(x);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FiFunc_ValidInput_Calculation()
        {
            double x = 1;
            double expectedResult = Math.Asin(-0.25 * Math.Pow(x, 3));

            double result = Methods.FiFunc(x);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FiFuncDer_ValidInput_Calculation()
        {
            double x = 1;
            double expectedResult = -3 * Math.Pow(x, 2) * (1 / Math.Sqrt(16 - Math.Pow(x, 6)));

            double result = Methods.FiFuncDer(x);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(-1, 0.5, 0.5, ExpectedResult = true)]
        [TestCase(-1, 0.5, -1, ExpectedResult = false)]
        public bool CheckFI_ValidInput_ExpectedResult(double a, double b, double x0)
        {
            double q = Math.Abs(Methods.FiFuncDer(b));

            return Methods.CheckFI(a, b, x0, q);
        }

        [Test]
        public void SimpleIteration_InvalidFiFunction_Exception()
        {
            _x0 = -1;

            Assert.Throws<ArgumentException>(() => Methods.SimpleIteration(_a, _b, _x0));
        }

        [Test]
        public void SimpleIteration_ValidInput_ReturnX()
        {
            double expectedResult = 0;

            double result = Methods.SimpleIteration(_a, _b, _x0);

            Assert.AreEqual(expectedResult, result, Methods.epsilon);
        }

        [Test]
        public void Dichotomy_ValidInput_ReturnX()
        {
            double expectedResult = 0;

            double result = Methods.Dichotomy(_a, _b);

            Assert.AreEqual(expectedResult, result, Methods.epsilon);
        }

        [Test]
        public void MNewtonMethod_ValidInput_ReturnX()
        {
            double expectedResult = 0;

            double result = Methods.MNewtonMethod(_a, _b);

            Assert.AreEqual(expectedResult, result, Methods.epsilon);
        }



        [Test]
        public void APrioriDichotomy_ValidInput_ExpectedResult()
        {
            int expectedResult = (int)(Math.Log((_b - _a) / Methods.epsilon) / Math.Log(2)) + 1;

            int result = Methods.APrioriDichotomy(_a, _b);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AprioriSI_ValidInput_ExpectedResult()
        {
            double x0 = 1;
            double q = Math.Abs(Methods.FiFuncDer(_b));
            int expectedResult = (int)((Math.Log(Math.Abs(Methods.FiFunc(x0) - x0) / ((1 - q) * Methods.epsilon))) / Math.Log(1 / q)) + 1;

            int result = Methods.AprioriSI(_b, x0);

            Assert.AreEqual(expectedResult, result);
        }

  
        [Test]
        public void AllRoots_FluentAssertions()
        {
            var expectedList = new List<double> { 0.0, 0.0, 0.0};
            var actualList = Methods.AllRoots(_a,_b,_x0);
            actualList.Should().BeEquivalentTo(expectedList, options => options.Using<double>(ctx => ctx.Subject.Should().BeApproximately(ctx.Expectation, Methods.epsilon)).WhenTypeIs<double>());
        }

        [Test]
        public void KindsOfFunction_FluentAssertions()
        {
            double x = 0;
            string actualString = Methods.KindsOfFunction(x);
            string expectedString = "F(x) = 0\nF'(x) = 4\nF''(x) = 0";
            actualString.Should().Contain(expectedString);

        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            Methods.Apost1 = 0;
            Methods.Apost2 = 0;
            Methods.Apost3 = 0;
            Methods.qSI = 0;
        }

        [TearDown]
        public void AfterEach()
        {
            // Здійснюємо завершальні дії після кожного тесту, якщо потрібно.
        }


    }
}


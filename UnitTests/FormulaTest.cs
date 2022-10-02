using calendar_matrix;
using NSubstitute;
using NUnit.Framework;

namespace Kmh.UnitTests
{
    //NirmulEI2I(800)*0.5+NirmulEI7I(ED7ED)*0.5

    public class FormulaTest
    {

        [Test]
        public void TestSimpleFormula()
        {
            var string1 = "hello world";
            var string2 = "hello world";
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void TestSimpleCalculator()
        {
            var _calculator = Substitute.For<ICalculator>();
            _calculator.Add(1, 2).Returns(3);
            Assert.That(_calculator.Add(1, 2), Is.EqualTo(3));
        }





    }
}

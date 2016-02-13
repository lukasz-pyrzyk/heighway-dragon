using HeighwayDragon.Calculations.DomainLayer;
using HeighwayDragon.Calculations.ServiceLayer;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace HeighwayDragon.Tests.Calculations
{
    [TestFixture]
    public class CSharpCalculatorTests
    {
        private const double Tolerance = 0.0005;
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void CalculateX1_ReturnsCorrectValue()
        {
            IDragonCalculator calculator = new CSharpCalculator();

            float x = _fixture.Create<float>();
            float y = _fixture.Create<float>();

            float result = calculator.CalculateX1(x, y);

            float expected = -0.4F * x - 1;

            Assert.That(result, Is.EqualTo(expected).Within(Tolerance));
        }

        [Test]
        public void CalculateY1_ReturnsCorrectValue()
        {
            IDragonCalculator calculator = new CSharpCalculator();

            float x = _fixture.Create<float>();
            float y = _fixture.Create<float>();

            float result = calculator.CalculateY1(x, y);

            float expected = -0.4F * y + 0.1F;

            Assert.That(result, Is.EqualTo(expected).Within(Tolerance));
        }

        [Test]
        public void CalculateX2_ReturnsCorrectValue()
        {
            IDragonCalculator calculator = new CSharpCalculator();

            float x = _fixture.Create<float>();
            float y = _fixture.Create<float>();

            float result = calculator.CalculateX2(x, y);

            float expected = 0.76F * x - 0.4F * y;

            Assert.That(result, Is.EqualTo(expected).Within(Tolerance));
        }


        [Test]
        public void CalculateY2_ReturnsCorrectValue()
        {
            IDragonCalculator calculator = new CSharpCalculator();

            float x = _fixture.Create<float>();
            float y = _fixture.Create<float>();

            float result = calculator.CalculateY2(x, y);

            float expected = 0.4F * x + 0.76F * y;

            Assert.That(result, Is.EqualTo(expected).Within(Tolerance));
        }

    }
}

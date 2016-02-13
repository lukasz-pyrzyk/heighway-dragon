using HeighwayDragon.Models;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace HeighwayDragon.Tests.Models
{
    [TestFixture]
    public class DragonPointTests
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void CanAssingValuesByCtor()
        {
            double x = _fixture.Create<double>();
            double y = _fixture.Create<double>();

            DragonPoint point = new DragonPoint(x, y);
            Assert.That(point.X, Is.EqualTo(x));
            Assert.That(point.Y, Is.EqualTo(y));
        }


        [Test]
        public void CalculatesCorrectXPosition()
        {
            int min = 0;
            int max = 99;
            int width = 100;
            DragonPoint point = new DragonPoint(50, 50);
            int newPosition = point.CalculateXPosition(min, max, width);

            Assert.That(newPosition, Is.EqualTo(49));
        }

        [Test]
        public void CalculatesCorrectXPositionWhenXIsTheHighestValue()
        {
            int min = 0;
            int max = 99;
            int width = 100;
            DragonPoint point = new DragonPoint(99, 99);
            int newPosition = point.CalculateXPosition(min, max, width);

            Assert.That(newPosition, Is.EqualTo(99));
        }

        [Test]
        public void CalculatesCorrectYPosition()
        {
            int min = 0;
            int max = 99;
            int height = 100;
            DragonPoint point = new DragonPoint(50, 50);
            int newPosition = point.CalculateYPosition(min, max, height);

            Assert.That(newPosition, Is.EqualTo(49));
        }

        [Test]
        public void CalculatesCorrectXPositionWhenYIsTheHighestValue()
        {
            int min = 0;
            int max = 99;
            int width = 100;
            DragonPoint point = new DragonPoint(99, 99);
            int newPosition = point.CalculateYPosition(min, max, width);

            Assert.That(newPosition, Is.EqualTo(99));
        }

    }
}

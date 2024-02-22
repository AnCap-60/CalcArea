using CalcAreaLib;

namespace CalcAreaTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShapeCreation()
        {
            Shape circle = new Circle(10.0);
            Shape triangle = new Triangle(1, 1, 1);
        }

        [Test]
        public void CircleSquare()
        {
            Circle circle = new Circle(3);
            Assert.That(circle.GetSquare(), Is.EqualTo(9 * Math.PI));
        }

        [Test]
        public void TriangleSquare()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.That(triangle.GetSquare(), Is.EqualTo(6));
        }

        [Test]
        public void IsTriangleRectangular()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.That(triangle.IsRectangular);
            
            Triangle triangle1 = new(3, 4, 6);
            Assert.That(!triangle1.IsRectangular);
        }

        [Test]
        public void InCorrectCreation()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle());
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, 1, 1, 1, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 20));

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1.0));
        }

        [Test]
        public void RuntimeTypeDefinition()
        {
            Shape shape;
            bool isTriangle = Random.Shared.Next() % 2 == 0;

            Assert.DoesNotThrow(() =>
            {
                if (isTriangle)
                    shape = new Triangle(3, 4, 5);
                else
                    shape = new Circle(3);

                shape.GetSquare();
            });
        }
    }
}
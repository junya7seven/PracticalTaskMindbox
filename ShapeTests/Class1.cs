using PracticalTaskMindbox.Shapes;
using PracticalTaskMindbox.Shapes.Interface;
using Xunit;

namespace ShapeTests
{
    public class Class1
    {
        [Fact]
        public void Circle_CalculateArea_ReturnsCorrectValue()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;
            Assert.Equal(expectedArea, circle.CalculateArea(), precision: 5);
        }

        [Fact]
        public void Triangle_CalculateArea_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.Equal(expectedArea, triangle.CalculateArea(), precision: 6);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void ShapeFactory_CreateCircle_ReturnsCircle()
        {
            var shape = ShapeFactory.CreateShape("circle", 5);
            Assert.IsType<Circle>(shape);
        }

        [Fact]
        public void ShapeFactory_CreateTriangle_ReturnsTriangle()
        {
            var shape = ShapeFactory.CreateShape("triangle", 3, 4, 5);
            Assert.IsType<Triangle>(shape);
        }

    }
}

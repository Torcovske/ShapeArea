namespace TetsTask.Tests.ShapeArea;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Triangle_GetArea_ValidTriangle_ReturnsCorrectValue()
    {
        // Arrange
        double a = 3;
        double b = 4;
        double c = 5;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        double area = triangle.GetArea();

        // Assert
        Assert.AreEqual(6, area, 0.001);
    }

    [TestMethod]
    public void Triangle_GetArea_InvalidTriangle_ReturnsZero()
    {
        // Arrange
        double a = 0;
        double b = 2;
        double c = 3;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        double area = triangle.GetArea();

        // Assert
        Assert.AreEqual(0, area, 0.001);
    }

    [TestMethod]
    public void Triangle_IsRightTriangle_ValidRightTriangle_ReturnsTrue()
    {
        // Arrange
        double a = 3;
        double b = 4;
        double c = 5;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    public void Triangle_IsRightTriangle_ValidNonRightTriangle_ReturnsFalse()
    {
        // Arrange
        double a = 3;
        double b = 4;
        double c = 6;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.IsFalse(isRightTriangle);
    }
}
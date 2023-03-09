namespace TetsTask.Tests.ShapeArea;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void Circle_GetArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5.0;
        Circle circle = new Circle(radius);
        double expectedArea = Math.PI * (radius * radius);

        // Act
        double actualArea = circle.GetArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea, 0.0001);
    }

    [TestMethod]
    public void Circle_GetArea_ZeroRadius_ReturnsZero()
    {
        // Arrange
        double radius = 0.0;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.GetArea();

        // Assert
        Assert.AreEqual(0, area);
    }

    [TestMethod]
    public void Circle_GetArea_NegativeRadius_ReturnsZero()
    {
        // Arrange
        double radius = -5.0;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.GetArea();

        // Assert
        Assert.AreEqual(0, area);
    }
}
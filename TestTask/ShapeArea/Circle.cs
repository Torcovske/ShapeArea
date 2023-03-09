namespace TestTask.ShapeArea;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        if (_radius <= 0)
        {
            return 0;
        }

        return Math.PI * (_radius * _radius);
    }
}
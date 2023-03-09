namespace TestTask.ShapeArea;

public class Triangle : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private bool? _isRightTriangle;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public double GetArea()
    {
        if (_a <= 0 || _b <= 0 || _c <= 0)
        {
            return 0;
        }
        //Вычисляем  площадь по формуле Герона
        //Квадрат произведения полупериметра, на разность полупериметра с каждой из сторон треугольника
        double halfPerimetr = (_a + _b + _c) / 2;
        return Math.Sqrt(halfPerimetr * (halfPerimetr - _a) * (halfPerimetr - _b) * (halfPerimetr - _c));
    }

    public bool IsRightTriangle()
    {
        if (_isRightTriangle is null)
        {
            double[] sides = {_a, _b, _c};
            Array.Sort(sides);
            _isRightTriangle = sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        return _isRightTriangle?? false;
    }
}
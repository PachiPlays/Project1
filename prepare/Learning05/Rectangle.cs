public class Rectangle : Shape
{
    private double _width;
    private double _height;
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        double area = _width * _height;
        return area;
    }
}
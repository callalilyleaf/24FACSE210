public abstract class Shape
{
    protected string _color ;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string newColor)
    {
        _color = newColor;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    // Instead of using virtual for the GetArea() function, we use abstract. Since it doesn't have a default shape for this class, we should use abstract that the child classes must declare the equation of GetArea() function by itself.

}
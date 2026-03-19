public class Fraction
{
    

private int _top;
private int _bottom;





    public Fraction()
    {
    _top = 1;
    _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    public string GetFractionString()
    {
        
        string fullFraction = $"{_top}/{_bottom}";
        
        return fullFraction;
    }

    public double GetDecimalValue()
    {
        double dec = (double)_top/_bottom;
        return dec;
    }

}


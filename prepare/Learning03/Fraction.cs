using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{   

    private int _top ;
    private int _bottom;
    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    
    public Fraction(int wholeNumber)
    {   // Get the wholeNumber in fraction
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {   // Get the fraction number
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int new_top)
    {
        _top = new_top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int new_bottom)
    {
        _bottom = new_bottom;
    }

    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}
    


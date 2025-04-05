using System;
public class Fraction
{
    private int _top;
    private int _bottom;

// Constructor that initializes fraction to 1/1
    public Fraction()
    {
        _top= 1;
        _bottom= 1;
        
    }
    //constructor takes only numerator and sets denomiator to 1
    public Fraction(int wholeNumber)
    {
        _top=wholeNumber;
        _bottom=1;
    }

    public Fraction(int top, int bottom)
    {
        _top=top;
        _bottom=bottom;
    }

//getter and setter for top
    public int Top
    {
        get{return _top;}
        set {_top=value;}

    }
    
    //getter and setter for bottom
    public int Bottom
    {
        get{ return _bottom;}
        set {_bottom = value;}
    }


    

     // Returns "top/bottom" format
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Returns decimal value (e.g., 3.0 / 4.0 = 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}


using System;

public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;

    }

    public Fraction(int wholeNum)
    {
        _topNum = wholeNum;
        _bottomNum = 1;

    }
    
    
    
    
    public Fraction(int topNum, int bottomNum)

    {
        _topNum = topNum;
        _bottomNum = bottomNum;
    }

    public string GetFractionString()
    {
        return $"{_topNum}/{_bottomNum}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNum / (double)_bottomNum;
    }






}



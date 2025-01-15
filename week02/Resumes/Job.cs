using System;

class Job
{
    public string __jobTitle;
    public int _startYear;
    public int _endYear;



public void Display()
{
    
    Console.WriteLine($"{__jobTitle} ({_startYear}) - ({_endYear})");
}

}
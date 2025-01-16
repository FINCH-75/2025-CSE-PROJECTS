using System;

class Job
{
    public string __jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
  


public void Display()
{
    
    Console.WriteLine($"{__jobTitle} {_company} ({_startYear}) - ({_endYear}) ");
}

       
}
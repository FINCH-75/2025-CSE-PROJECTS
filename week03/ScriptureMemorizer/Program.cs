using System;

class Program
{
    static void Main(string[] args)
    {
       Reference reference= new Reference("Mosiah" , 3,17,17);
       Console.WriteLine(reference.GetDisplayText());
    }
}
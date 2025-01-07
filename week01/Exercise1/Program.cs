using System;

class Program
{
    static void Main(string[] args)
    {
        
       // Ask for first name and middle and last names. Then have console read and store names as string variables.
       Console.Write("What is your first name? ");
       string firstName = Console.ReadLine();
       Console.Write("What is your middle name? ");
       string middleName = Console.ReadLine();
       Console.Write("What is your last name? ");
       string lastName = Console.ReadLine();
       Console.WriteLine("");
       // Display names in format Last name , First name Middle name Last name.
       Console.WriteLine($"Your name is {lastName}, {firstName} {middleName} {lastName}. ");
}
}
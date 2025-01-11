using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user their grade percentage.
        Console.Write("What is your grade percentage? ");
        string Grade = Console.ReadLine();

        // convert string to integer.
        int gradeNum = int.Parse(Grade);


        // stretch challeng getting symbol after grade
        // divide and get remander of number (modulo)
        int grade = gradeNum % 10;

        // Convert to string
        string sym = grade.ToString();

       // Create if else statement to find whether you get a symbol or not (grade>60<92) get a + or _
    if (gradeNum > 60 && gradeNum <= 92)
    {
        if (grade >= 7)
        {
            
            sym = "+";
        }

        else if (grade <= 2)
        {
            
            sym = "-";
        }

        else
        {
            sym = "";
        }

    }
    else
    {
        sym = "";
    }

        // create letter string to use for letter grade.
        string letter = "";
        
        // create if and else statements to find letter the user got.
        if (gradeNum >= 90)
        {
            letter = "A";

        }

        else if (gradeNum >= 80)
        {
            letter = "B";
        }

        else if (gradeNum >= 70)
        {
            letter = "C";
        }

        else if (gradeNum >= 60)
        {
            letter = "D";
        }

        else
        {
           letter = "F";
        }

        
        // display the users letter grade.
        Console.WriteLine($"You have an  {letter}{sym} in the class.");


        // create if and else statement to find if user passed the class. If less than or equal to 69 failure of class.
        if (gradeNum <= 69)
        {
            Console.WriteLine("Sorry you did not pass. Try again next year.");
        }

        else 
        {
            Console.WriteLine("Congrats you passed!");
        }

            
        





    }
}
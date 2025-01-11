using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

    // Call all functions in main function
    DisplayMessage();
    string name = DisplayUserName();
    int squared = FavNumber();
    DisplayFinal(name ,squared);
    
    
// Create DisplayMessage function.
static void DisplayMessage()
{
    Console.WriteLine("Welcome to the Program.");
}

// Create DisplayUserName function and return name.
static string DisplayUserName()
{
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
   
    return name;
}

// Create FavNumber fuction.
static int FavNumber()
{ 
    int favNum = 0;
    
    Console.Write("Please enter your favorite number: ");
    string n1 = Console.ReadLine();
    favNum = int.Parse(n1);

// Make users favNum squared and return squared.
    int squared = favNum*favNum;
    return squared;
}


// Create DisplayFinal function with name and squared 
static void  DisplayFinal(string name, int squared)
{
    Console.WriteLine($"{name}, your number squared is {squared}");

}    
    }
}
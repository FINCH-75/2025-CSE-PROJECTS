using System;

class Program
{
    static void Main(string[] args)
    {

    DisplayMessage();
    string name = DisplayUserName();
    int squared = AddNumbers();
    DisplayFinal(name , squared);
    
    //Console.Write($"Your favorite number squared is: {squared}");
     
static void DisplayMessage()
{
    Console.WriteLine("Welcome to the Program.");
}

static string DisplayUserName()
{
    Console.Write("What is your name?");
    string name = Console.ReadLine();
   
    return name;
}

static int AddNumbers()
{
    
    int favNum = 0;
    
    Console.WriteLine("What is your favorite number?");
    string n1 = Console.ReadLine();
    favNum = int.Parse(n1);


// make users favorite number squared //
    int squared = favNum*favNum;
    return squared;


}

static void  DisplayFinal(string name, int squared)
{
Console.WriteLine($"{name} Your number squared is {squared}");

}


//DisplayWelcome - Displays the message, "Welcome to the Program!"
//PromptUserName - Asks for and returns the user's name (as a string)
//PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
//SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
//DisplayResult

        
    }
}
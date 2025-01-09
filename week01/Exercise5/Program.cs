using System;

class Program
{
    static void Main(string[] args)
    {

    DisplayMessage();
    DisplayPersonalMessage();
    int sum = AddNumbers();
    Console.WriteLine($"The sum is: {sum}");
     
static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage()
{
    Console.WriteLine("What is your Username?");
    string userName = Console.ReadLine();
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers()
{
    
    int num1=0;
    int num2=0;
    Console.WriteLine("give me a number?");
    string n1 = Console.ReadLine();
    num1 = int.Parse(n1);

Console.WriteLine("give me another number?");
    string n2 = Console.ReadLine();
    num2 = int.Parse(n2);

    int sum = num1 + num2;
    return sum;



}


//DisplayWelcome - Displays the message, "Welcome to the Program!"
//PromptUserName - Asks for and returns the user's name (as a string)
//PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
//SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
//DisplayResult

        
    }
}
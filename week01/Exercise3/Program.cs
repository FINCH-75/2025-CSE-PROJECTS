using System;

class Program
{
    static void Main(string[] args)
    {
    // Use random generator and use 1-100.
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 100);
    
    // create guess integer and give it a value of 0.
    int guess = 0;

// create a while loop that uses if and else statements to asks the user to give a number and will only finish when user guesses correctly.
while (guess != number)
{
    Console.Write("What is your guess? ");
    string userGuess = Console.ReadLine();
     guess = int.Parse(userGuess);

   
if (guess > number)
    {
        Console.WriteLine("Wrong please guess lower");
        
    }
     
     else if (guess < number)
     {
        Console.WriteLine("Wrong please guess higher");
     }

     else
     {
        Console.WriteLine("Good job you guessed it!!");
     }

}


    
    
}
    
}
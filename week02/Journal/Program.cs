using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello journal world");


        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt();

         Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Your Entry: ");
        string UserEntry = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        Entry entry1 = new Entry();
        entry1._date = dateText;
        entry1._prompt = randomPrompt;
        entry1._entryText = UserEntry;

        entry1.Display();
        
    }

    
}



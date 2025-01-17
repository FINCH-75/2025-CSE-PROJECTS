using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your C# journal");
        Console.WriteLine("Please enter a number between 1 and 5.");
        Console.WriteLine("\n What would you like to select?");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        while (true)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to a journal file");
            Console.WriteLine("4. Load from a journal file.");
            Console.WriteLine("5. Quit");
            Console.Write("\n>");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: > ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _prompt = prompt,
                        _entryText = response
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("\nEntry added successfully!");
                    
            }

            else if (choice == "2")
            {
                    Console.WriteLine("\nAll Journal Entries:");
                    journal.DisplayAll();
                    
            }

            else if (choice == "3")
            {
                    Console.Write("Enter journal file name to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    
                    
            }

            else if (choice == "4")
            {
                    Console.Write("Enter journal file name to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    
                    
            }

            else if(choice == "5")
            {
                Console.WriteLine("\nGood Bye!");
                break;
            }

            else
            {
                Console.WriteLine("Please enter a number between 1 and 5");
            }



        }

        
        
    }

    
}



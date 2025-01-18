using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your C# journal");
        Console.WriteLine("Please enter a number between 1 and 5.");
        Console.WriteLine("\n What would you like to select?");
            // Create a new instance of Journal class and assigned it to a variable named Journal 
        Journal journal = new Journal();
            // // Create a new instance of PromptGenerator class and assigned it to a variable named PromptGenerator
        PromptGenerator promptGenerator = new PromptGenerator();
            // Created a while loop for the enterface of the program, to ask the user what would they like to do. The while loop is a boolean
            // loop that will run until the user selects 5 and it breaks.
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
            // IF the user selects 1  the program selects a random prompt and displays it to the user. It then stores the prompt and entry.
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
            // If the user selects 2 the program will then call the displayAll method and displays the journal.
            else if (choice == "2")
            {
                    Console.WriteLine("\nAll Journal Entries:\n");
                    journal.DisplayAll();
                    
            }
            // If the user selects 3 the program will  call the SaveToFile method, ask for a journal file name and save the entry and prompt
            // and date to a file
            else if (choice == "3")
            {
                    Console.Write("Enter journal file name to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    
                    
            }
            // If the user selects 4 the program will call the LoadFromFile method and ask the user what journal file and load it if it exists.
            else if (choice == "4")
            {
                    Console.Write("Enter journal file name to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    
                    
            }
            // If the user selects 5 the while true loop will break and display "Thanks for creating a journal Good Bye!" and the program will
            // terminate.
            else if(choice == "5")
            {
                Console.WriteLine("\nThanks for creating a journal Good Bye!");
                break;
            }

            else
            {
                Console.WriteLine("Please enter a number between 1 and 5");
            }



        }

        
        
    }

    
}



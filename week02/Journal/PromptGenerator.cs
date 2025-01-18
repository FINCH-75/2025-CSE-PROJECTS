using System;
using System.Collections.Generic;
    // created the class PromptGenerator
public class PromptGenerator()
{
    // Created a list of prompts to display for the user and stored them in a list of strings called _prompts.
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "What did I do today to bring me closer to Christ?", 
        "What did I do today to strenghthen my marraige?",

    };


    // created a method to call a random method
    public string GetRandomPrompt() 
    {
       Random random = new Random();
       int index = random.Next(_prompts.Count);
       return _prompts[index];

    }
    
}
    // Created an Entry class.
public class Entry()
{
    // Created objects date , prompt and entry text for the journal.
    public string _date;
    public string _prompt;
    public string _entryText;

    // Created a display method for the journal entries.
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - PROMPT: {_prompt} \nRESPONSE: {_entryText}");
        
    }

}
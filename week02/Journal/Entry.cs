public class Entry()
{

    public string _date;
    public string _prompt;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_prompt} - {_entryText}");
        
    }

}
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

        if (_endVerse == 0)
        {
            _endVerse = verse;
        }

        else 
        {
            _endVerse = endVerse;
        }

        
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}" + (_verse != _endVerse ? $"-{_endVerse}" : "");
    }

}
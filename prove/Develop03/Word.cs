class Word
{
    private string _word;
    private Boolean _visible;

    public Word(string word)
    {
        _word = word;
        _visible = true;
    }

    public void Hide()
    {
        _visible = false;
    }

    public void Show()
    {
        _visible = true;
    }

    public Boolean IsHidden()
    {
        if (_visible == true)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    public string GetRenderedText()
    {
        string word = "";
        if (IsHidden() == true)
        {
            foreach (char letter in _word)
            {
                word += "_";
            }
            return word;
        }

        else
        {
            return _word;
        }

    }
}
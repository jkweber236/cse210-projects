using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureWords = new List<Word>();


    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        string[] words = scriptureText.Split(" ");

        foreach(string word in words)
        {
            Word newWord = new Word(word);
            _scriptureWords.Add(newWord);
        }
    }

    public void HideWords() 
    {
        int count = 1;
        while(count < 4)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, _scriptureWords.Count());
            if (_scriptureWords[index].IsHidden() == false)
            {
                _scriptureWords[index].Hide();
                count += 1;
            }
        }
    }

    public string GetRenderedText() 
    {
        string text = "";
        foreach(Word word in _scriptureWords)
        {
            text += word.GetRenderedText();
            text += " ";
        }
        return text;
    }

    public Boolean IsCompletelyHidden()
    {
        foreach(Word word in _scriptureWords)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
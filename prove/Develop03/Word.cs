public class Word
{
    private string _word = "";
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetRenderedText()
    {   
        char[] punctuationMarks = { ',', '.', ';', ':', '!', '?', '-' };

        string hiddenWord = new string(_word.Select( c => punctuationMarks.Contains(c) ? c : '_').ToArray());

        return _hidden ? hiddenWord : _word;
    }
    public void Hide()
    {   
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

}
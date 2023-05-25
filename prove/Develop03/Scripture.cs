using System;
using System.Linq;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>(); 

    public Scripture(Reference reference, string words)
    {
        _reference = reference;

        string[] wordsInVerse = words.Split(" ");

        foreach (string word in wordsInVerse)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }   

    public string GetRenderedText()
    {

        List<string> verse = new List<string>();

        foreach (Word word in _words)
        {
            string aWord = word.GetRenderedText();
            verse.Add(aWord);
        }
        
        return $"{_reference.GetRenderedText()} {string.Join(" ", verse)}";
    }

    public void HideWords()
    {
        Random random = new Random();
        List<int> indices = new List<int>();

        // Stretch challenge
        for (int i = 0; i < 3; i++) 
        {
            int randomIndex;

            do
            {
                randomIndex = random.Next(_words.Count);
            } while (indices.Contains(randomIndex) || _words[randomIndex].IsHidden());

            indices.Add(randomIndex);
            _words[randomIndex].Hide();

        }
    }

    public bool IsCompletelyHidden()
    {   
        bool AllHidden = _words.All( word => word.IsHidden());
        return AllHidden;
    }
}


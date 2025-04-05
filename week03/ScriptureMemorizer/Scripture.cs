public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');

        foreach (string word in splitWords)
    {
        Word w = new Word(word);
        _words.Add(w);
    }

    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();

    // Create a new list to hold words that are not hidden
    List<Word> visibleWords = new List<Word>();

    // Add only the visible words to the new list
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    // Hide up to 'count' random words
    for (int i = 0; i < count && visibleWords.Count > 0; i++)
    {
        int index = rand.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index);
    }
    }

    public string GetDisplayText()
    {
        string wordsText = "";

    foreach (Word word in _words)
    {
        wordsText += word.GetDisplayText() + " ";
    }

    wordsText = wordsText.Trim(); // Remove the last extra space
    return _reference.GetDisplayText() + " - " + wordsText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            return false; // If any word is not hidden, return false
        }
    }
    return true; // All words are hidden

    }
    
}
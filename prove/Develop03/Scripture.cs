public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;

    private List<int> _usedIndexes = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        int number = 0;

        while (number < 2)
        {
            if (!IsCompletelyHidden())
            {
                int index = GetUniqueRandomIndex(random);
                _words[index].Hide();
                number += 1;
            }
            else
            {
                break;
            }

        }
    }

    private int GetUniqueRandomIndex(Random random)
    {
        int index = random.Next(0, _words.Count);

        while (_usedIndexes.Contains(index))
        {
            index = random.Next(0, _words.Count);
        }

        _usedIndexes.Add(index);

        return index;
    }

    public void GetDisplayText()
    {
        Console.Write(_reference.GetDisplayText() + ": ");
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(word.GetDisplayText() + " ");
            }
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
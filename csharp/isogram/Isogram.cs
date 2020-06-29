using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        char[] wordChars = word.ToLower().ToCharArray();
        Array.Sort(wordChars);
        int i = 0;
        bool isIsogram = true;
        while (isIsogram && i < wordChars.Length - 1)
        
        {
            if (Char.IsLetter(wordChars[i]) && wordChars[i] == wordChars[i + 1])
                isIsogram = false;
            i++;
        }
        return isIsogram;
    }
}

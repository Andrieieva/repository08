using System;
class Program
{
    static bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
                return false;
        }
        return true;
    }
    static void AnalyzeString(string input)
    {
        int alphabeticCount = 0;
        int digitCount = 0;
        int separatorCount = 0;
        int punctuationCount = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
                alphabeticCount++;
            else if (char.IsDigit(c))
                digitCount++;
            else if (char.IsSeparator(c))
                separatorCount++;
            else if (char.IsPunctuation(c))
                punctuationCount++;
        }
        Console.WriteLine($"Alphabetic characters: {alphabeticCount}");
        Console.WriteLine($"Digit characters: {digitCount}");
        Console.WriteLine($"Separator characters: {separatorCount}");
        Console.WriteLine($"Punctuation characters: {punctuationCount}");
    }
    static string SortString(string input)
    {
        char[] chars = input.ToLower().ToCharArray(); 
        Array.Sort(chars);
        return new string(chars);
    }
    static char[] FindDuplicates(string input)
    {
        char[] characters = input.ToLower().ToCharArray(); 
        int length = characters.Length;
        List<char> duplicates = new List<char>();
        for (int i = 0; i < length; i++)
        {
            if (characters[i] != ' ')
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (characters[i] == characters[j] && !duplicates.Contains(characters[i]))
                    {
                        duplicates.Add(characters[i]);
                        break;
                    }
                }
            }
        }
        return duplicates.OrderBy(c => c).ToArray();
    }
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        bool areEqual = CompareStrings(str1, str2);
        Console.WriteLine($"Are strings equal: {areEqual}");
        string text = "Hello, Oleksii!";
        AnalyzeString(text);
        string sortedString = SortString(text);
        Console.WriteLine($"Sorted string: {sortedString}");
        char[] duplicates = FindDuplicates(text);
        Console.WriteLine($"Duplicated characters: {string.Join(", ", duplicates)}");
    }
}
using System;

public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir ifade girin:");
        string input = Console.ReadLine();

        bool isPalindrome = input.IsPalindrome();

        if (isPalindrome)
            Console.WriteLine("Girdi bir palindromdur.");
        else
            Console.WriteLine("Girdi bir palindrom değildir.");
    }
}

// Palindrome or not
using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        string cleanedInput = input.Replace(" ", "").ToLower();
        
        int left = 0;
        int right = cleanedInput.Length - 1;

        while (left < right)
        {
            if (cleanedInput[left] != cleanedInput[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        string testString = "madam";

        if (IsPalindrome(testString))
        {
            Console.WriteLine($"\"{testString}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{testString}\" is not a palindrome.");
        }
    }
}
using System;

class Palindrome
{
  static void Main()
  {
    Console.WriteLine("Enter a word and we'll check whether it's a palindrome or not!");
    string userInput = Console.ReadLine();
    bool result = isPalindrome(userInput);
    if(result)
    {
      Console.WriteLine("This is a palindrome.");
    }
    else
    {
      Console.WriteLine("This is not a palindrome.");
    }
  }

  public static bool isPalindrome(string userInput)
  {
    char[] charArray = userInput.ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = new string(charArray);
    if(userInput == reversedWord)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
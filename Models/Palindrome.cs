using System;

namespace Palindrome.Models
{
  class Palindromes
  {
    public string UserInput;

    public Palindromes(string userInput)
    {
      UserInput = userInput;
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
}
using System;
using Palindrome.Models;

namespace Palindrome
{
  public class program
  {
    static void Main()
    {
      Console.WriteLine("Enter a word and we'll check whether it's a palindrome or not!");
      string userInput = Console.ReadLine();
      bool result = Palindromes.isPalindrome(userInput);
      if(result)
      {
        Console.WriteLine("This is a palindrome.");
      }
      else
      {
        Console.WriteLine("This is not a palindrome.");
      }
    }
  }
}
using System;
namespace Palindromes.Models
{
  class Palindromes
  {
    public string Word;
    public Word(string word)
    {
      Word = word;
    }

    public bool isPalindrome()
    {
      char[] arrayWord = Word.ToCharArray();
      char[] reverseWord = (char[]) arrayWord.Clone();
      Array.Reverse(arrayWord);

      string stringWord = string.Join(",", arrayWord);
      string stringReversed = string.Join(",", reverseWord);

      if(stringWord == stringReversed)
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
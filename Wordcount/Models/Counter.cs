using System;
using System.Text;
using System.Collections.Generic;

namespace Wordcounter.Models
{

  public class Counter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }

    public Counter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }

    public int findWord()
    {
      StringBuilder noPunctuation = new StringBuilder();
      string charOnlySentence;

      foreach (char c in Sentence)
      {
        if (!char.IsPunctuation(c))
          noPunctuation.Append(c);
      }

      charOnlySentence = noPunctuation.ToString();

      int wordCount = 0;
      string[] sentenceWords = charOnlySentence.Split(' '); 

      for(int i = 0; i < sentenceWords.Length; i++)
      {
        string currentWord = sentenceWords[i].ToLower();
        if(Word == currentWord)
        {
          wordCount++;
        }
      }
      
      return wordCount;
    }
  }
}
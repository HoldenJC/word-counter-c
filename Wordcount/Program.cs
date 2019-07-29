using System;
using System.Collections.Generic;

using Wordcounter.Models;

namespace Wordcounter
{

  public class Program
  {

    public static void Main()
    {
      string userWord;
      string userSentence;

      Console.WriteLine("Enter a sentence:");
      userSentence = Console.ReadLine();
      Console.WriteLine("Enter a word to check for:");
      userWord = Console.ReadLine().ToLower();

      Counter wordCounter = new Counter(userWord, userSentence);
      int count = wordCounter.findWord();

      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(userWord);
      Console.ResetColor();
      Console.Write(" appears ");
      if(count == 1)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(count + " time");
      } else if(count > 1)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(count + " times");
      } else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(count + " times");
      }
    }
  }
}
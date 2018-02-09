using System.Collections.Generic;
using System;

namespace Hangmen.Models

{
  public class Hangman
  {
    private string _answer;
    private string _display;
    private int _guess;
    private static List<string> _words = new List<string> {"dogs", "monkies", "yomama", "picklerick", "todolist"};
    private List<char> _lettersGuessed = new List<char> {};

    public string GetAnswer()
    {
      return _answer;
    }

    public string GetDisplay()
    {
      return _display;
    }

    public void SetDisplay(string newDisplay)
    {
      _display = newDisplay;
    }

    public int GetGuess()
    {
      return _guess;
    }

    public void SetGuess(int newGuess)
    {
      _guess = newGuess;
    }

    public int GetWordsCount()
    {
      return _words.Count;
    }

    public List<char> GetLettersGuessed()
    {
      return _lettersGuessed;
    }

    public void AddGuessedLetter(char newGuess)
    {
      _lettersGuessed.Add(newGuess);
    }

    public string ChooseWord()
    {
      int wordsLength = GetWordsCount();
      Random rnd = new Random();
      int wordIndex = rnd.Next(wordsLength);
      return _words[wordIndex];
    }

    public void SetAnswer(string word)
    {
      _answer = word;
    }

    public string MakeDisplay(string word, List<char> lettersGuessed)
    {
      string answer = "";
      for (int x =0; x < word.Length; x++){
        if (lettersGuessed.Contains(word[x])){
        char letter = word[x];
        answer += letter + " ";
      }else {
        answer += "_ ";
      }
    }
    return answer;
  }
  }
}

//
// public class Program
//   {
//     public static void Main()
//     {
//       Hangman Buster = new Hangman();
//       List<char> guessedLetters = new List<char> {'a','e','o','i','g','h'};
//       string StringDisplay = Buster.MakeDisplay("bud", guessedLetters);
//       Console.WriteLine(StringDisplay);
//     }
//
//   }

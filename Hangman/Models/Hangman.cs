namespace Hangman.Models
{
  public class HangmanGame
  {
    public string AnswerWord { get; set; }
    public int RemainingGuesses { get; set; }

    public int LettersCorrect { get; set; }
    public char[] CorrectLetters { get; set; }
    public char[] IncorrectLetters { get; set; }

    public HangmanGame(string word) {
      AnswerWord = word;
      RemainingGuesses = 6;
      LettersCorrect = 0;
      CorrectLetters = new char[word.Length];
      IncorrectLetters = new char[26];
    }

    public void CheckLetter(char guess)
    {

    }
  }
}
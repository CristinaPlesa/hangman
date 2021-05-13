namespace Hangman.Models
{
  public class HangmanGame
  {
    public char[] AnswerWord { get; set; }
    public int RemainingGuesses { get; set; }

    public int LettersCorrect { get; set; }
    public char[] CorrectLetters { get; set; }
    public int CurrentIndexCorrect { get; set; }
    public char[] IncorrectLetters { get; set; }
    public int CurrentIndexNotCorrect { get; set; }

    public HangmanGame(string word) {
      AnswerWord = word.ToCharArray();
      RemainingGuesses = 6;
      LettersCorrect = 0;
      CorrectLetters = new char[word.Length];
      IncorrectLetters = new char[26];
      CurrentIndexCorrect = 0;
      CurrentIndexNotCorrect = 0;
    }

    public void CheckLetter(char guess)
    {
      int occurencesInWord = 0;
      for(int i = 0; i < AnswerWord.Length; i++)
      {
        if(AnswerWord[i] == guess)
        {
          occurencesInWord++;
        }
      }
      if(occurencesInWord == 0)
      {
        RemainingGuesses--;
        IncorrectLetters[CurrentIndexNotCorrect] = guess;
        CurrentIndexNotCorrect++;
      }
      else
      {
        LettersCorrect += occurencesInWord;
        for(int i = 0; i<occurencesInWord; i++)
        {
        CorrectLetters[CurrentIndexCorrect] = guess;
        CurrentIndexCorrect++;
        }
      }
    }
  }
}
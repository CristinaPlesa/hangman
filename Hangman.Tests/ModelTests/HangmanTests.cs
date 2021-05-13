using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;

namespace Hangman.TestTools
{
  [TestClass]
  public class HangmanGameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfHangmanGame_HangmanGame()
    {
      HangmanGame newHangman = new("word");
      char[] wordArray = { 'w', 'o', 'r', 'd' };
      Assert.AreEqual(typeof(HangmanGame), newHangman.GetType());
      Assert.AreEqual(wordArray[0], newHangman.AnswerWord[0]);
    }

    [TestMethod]
    public void CheckLetter_ChecksIfLetterIsIncludedInWord_LettersCorrect()
    {
      //Arrange
      int lettersCorrect = 1;
      HangmanGame newHangman = new("word");
      //Act
      newHangman.CheckLetter('w');
      int result = newHangman.LettersCorrect;
      //Assert
      Assert.AreEqual(lettersCorrect, result);

    }

    [TestMethod]
    public void CheckLetter_ChecksIfLetterIsNotIncludedInWord_RemainingGuesses()
    {
      //Arrange
      int remainingGuesses = 5;
      HangmanGame newHangman = new("word");
      //Act
      newHangman.CheckLetter('t');
      int result = newHangman.RemainingGuesses;
      //Assert
      Assert.AreEqual(remainingGuesses, result);
    }
  }
} 
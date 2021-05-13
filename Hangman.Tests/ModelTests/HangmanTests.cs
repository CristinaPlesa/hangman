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
      Assert.AreEqual(typeof(HangmanGame), newHangman.GetType());
      Assert.AreEqual("word", newHangman.AnswerWord);
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
  }
} 
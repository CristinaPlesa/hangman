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
      HangmanGame newHangman = new();
      Assert.AreEqual(typeof(HangmanGame), newHangman.GetType());
    }
  }
}
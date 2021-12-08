using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    //Ties
    [TestMethod]
    public void GetWinner_InputsAreSame_ReturnStringOfTie()
    {
      //Arrange - create something to match expected result
      string expWinner = "Tie";
      string p1 = "Rock";
      string p2 = "Rock";

      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);

      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner);
    }
    [TestMethod]
    public void GetWinner_InputsToLower_ReturnStringOfTie()
    {
      //Arrange - create something to match expected result
      string expWinner = "Tie";
      string p1 = "rock";
      string p2 = "Rock";
      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);;

      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner);
    }

    //Player 2 Wins
    [TestMethod]
    public void GetWinner_Player2Wins_ReturnTrue()
    {
      //Arrange - create something to match expected result
      string expWinner = "p2";
      string p1 = "Rock";
      string p2 = "Paper";
      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);
      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner);
    }
    [TestMethod]
    public void GetWinner_Player2Wins_2Rock1Scissors()
    {
      //Arrange - create something to match expected result
      string expWinner = "p2";
      string p1 = "Scissors";
      string p2 = "Rock";
      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);
      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner);
    }

    //Player 1 Wins
    [TestMethod]
    public void GetWinner_Player1Wins_1Rock2Scissors()
    {
      //Arrange - create something to match expected result
      string expWinner = "p1";
      string p1 = "Rock";
      string p2 = "Scissors";
      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);
      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner); 
    }
    [TestMethod]
    public void GetWinner_Player1Wins_1Scissors2Paper()
    {
      //Arrange - create something to match expected result
      string expWinner = "p1";
      string p1 = "Scissors";
      string p2 = "Paper";
      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);
      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner); 
    }
    [TestMethod]
    public void GetWinner_Player2Wins_2Scissors1Paper()
    {
      //Arrange - create something to match expected result
      string expWinner = "p2";
      string p1 = "Paper";
      string p2 = "Scissors";
      //Act - get actual result from your class
      string actualWinner = Game.GetWinner(p1, p2);
      //Assert - make sure expected matches actual
      Assert.AreEqual(expWinner, actualWinner); 
    }
  }

}

// Player One:
// Rock
// Paper
// Scissors

// Player Two:
// Rock
// Paper
// Scissors

// DONE:
// P1: Rock - P2: Rock - Tie
// P1: Paper - P2: Paper - Tie
// P1: Scissors - P2: Scissors - Tie
// P1: Rock - P2: Paper - P2 Wins
// P1: Scissors - P2: Rock - P2 Wins
// P1: Paper - P2: Rock - P1 Wins
// P1: Rock - P2: Scissors - P1 Wins
// P1: Scissors - P2: Paper - P1 Wins


// P1: Paper - P2: Scissors - P2 Wins





// Test 1:
// If P1 and P2 input the same value, it will be a tie

// Test 2: If P1 inputs Rock and P2 inputs Paper, P2 Wins

// Test 3: etc.....
using System;
using RockPaperScissors;

class Program
{
  static void Main()
  {
    Console.WriteLine(" ");
    Console.WriteLine("Let's Play Rock Paper Scissors!");
    Console.WriteLine(" ");
    Console.WriteLine("Player One, choose rock, paper, or scissors");
    Console.WriteLine("---------------------------------");
    Console.WriteLine(" ");
    string p1Answer = Console.ReadLine();
    if ((p1Answer.ToLower() == "rock") || (p1Answer.ToLower() == "paper") || (p1Answer.ToLower() == "scissors"))
    {
      Console.WriteLine(" ");
      Console.WriteLine("Player Two, choose rock, paper, or scissors");
      Console.WriteLine("---------------------------------");
      Console.WriteLine(" ");
      string p2Answer = Console.ReadLine();

      if ((p2Answer.ToLower() == "rock") || (p2Answer.ToLower() == "paper") || (p2Answer.ToLower() == "scissors"))
      {
        string winner = Game.GetWinner(p1Answer, p2Answer);
        if (winner == "p1" || winner == "p2")
        {
          Console.WriteLine(" ");
          Console.WriteLine($"{winner.ToUpper()} WINS!");
          Console.WriteLine(" ");
        }
        else
        {
          Console.WriteLine(" ");
          Console.WriteLine($"IT'S A {winner.ToUpper()}!!");
          Console.WriteLine(" ");
        }
        Main();
      }
      else
      {
        Console.WriteLine(" ");
        Console.WriteLine("Please type one of the three options only");
        Console.WriteLine("---------------------------------");
        Console.WriteLine(" ");
        Main();
      }
    }
    else
    {
      Console.WriteLine(" ");
      Console.WriteLine("Please type one of the three options only");
      Console.WriteLine("---------------------------------");
      Console.WriteLine(" ");
      Main();
    }
  }
}
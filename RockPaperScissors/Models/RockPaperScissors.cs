namespace RockPaperScissors
{
  public class Game
  {
    public static string GetWinner(string p1, string p2)
    {
      p1 = p1.ToLower();
      p2 = p2.ToLower();
      if (p1 == p2)
      {
        return "Tie";
      }
      else if ((p1 == "rock" && p2 == "paper") || (p1 == "scissors" && p2 == "rock") || (p2 == "scissors" && p1 == "paper"))
      {
        {
          return "p2";
        }
      }
      else if ((p2 == "rock" && p1 == "paper") || (p2 == "scissors" && p1 == "rock") || (p2 == "paper" && p1 == "scissors"))
      {
        {
          return "p1";
        }
      }
      else
      {
        return "ERROR!!!!!";
      }
    }
    
  }
}
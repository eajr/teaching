using System;

namespace dotnet
{
  using dotnet.Models;

  class Program
  {
    static void Main(string[] args)
    {
      Player player1 = new Player();
      player1.AskName();
      player1.AskAge();

      Player player2 = new Player();
      player2.AskName();
      player2.AskAge();

      player1.GreetName("Bonjour Fucker");
      player1.AgeCompare();

      player2.GreetName("Faggot");
      player2.AgeCompare();
    }
  }
}

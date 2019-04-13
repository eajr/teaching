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

      GreetName("Bonjour", player1.Name);
      AgeCompare(player1.Age);
    }

    static void GreetName(string greeting, string name)
    {
      Console.WriteLine(greeting + " " + name);
    }

    static void AgeCompare(int age)
    {
      if (age >= 30)
      {
        Console.WriteLine("Holy shit you're old");
      }
      else if (age >= 18)
      {
        Console.WriteLine("You're gettin old fucker");
      }
      else
      {
        Console.WriteLine("Get off my lawn.");
      }
    }
  }
}

using System;

namespace dotnet
{
  using dotnet.Models;

  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();

      Player player = new Player();
      player.Health = 20;
      player.MovementSpeed = 10;
      player.AskName();

      Sword longsword = new Sword();
      longsword.Name = "Longsword";
      longsword.AttackPower = 10;

      player.Weapon = longsword;

      Monster kali = new Monster();
      kali.Name = "Kali, Goddess of Destruction";
      kali.Health = 100;
      kali.AttackPower = 12;
      kali.MovementSpeed = 100;

      player.GreetName("Greetings, ");
      Console.WriteLine("Great scots! You've been attacked!");
      Console.WriteLine(kali.Name + " has attacked you!");

      while (player.Health > 0) {
        Console.WriteLine("a: for attack, r: to run away");
        string action = Console.ReadLine();

        if (action == "r") {
          Console.WriteLine("She's too fast for you and has clawed you to death from behind!");
        }
        else if (action == "a") {
          int dice = rnd.Next(100);
          bool playerFirst;

          if (dice >= 0 && dice <= 10) {
            playerFirst = true;
            Console.WriteLine("You got the upperhand! You attack first!");
            kali.Health -= player.Weapon.AttackPower;
            Console.WriteLine("You hit her for " + player.Weapon.AttackPower + " damage.");
            Console.WriteLine("She has " + kali.Health + " health.");
            player.Weapon.Swing();
            player.Health -= kali.AttackPower;
            Console.WriteLine("She hits you for " + kali.AttackPower + " damage.");
            Console.WriteLine("You have " + player.Health + " health.");
          }
          else {
            playerFirst = false;
            Console.WriteLine("You lost the upperhand! She attacks you first!");
            player.Health -= kali.AttackPower;
            Console.WriteLine("She hits you for " + kali.AttackPower + " damage.");
            Console.WriteLine("You have " + player.Health + " health.");
            player.Weapon.Swing();
            kali.Health -= player.Weapon.AttackPower;
            Console.WriteLine("You hit her for " + player.Weapon.AttackPower + " damage.");
            Console.WriteLine("She has " + kali.Health + " health.");
          }
        }
        else {
          Console.WriteLine("Invalid action! You're probably dead...");
        }
      }
      Console.WriteLine("Game over");
    }
  }
}

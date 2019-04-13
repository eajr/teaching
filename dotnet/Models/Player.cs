namespace dotnet.Models {
  using System;

  public class Player : Character {

    public Sword Weapon;
    public Int16 Age;
    public string EyeColor;
    public Int16 Height;

    public void AskName()
    {
      Console.WriteLine("Whats your name?");
      Name = Console.ReadLine();
    }

    public void GreetName(string greeting)
    {
      Console.WriteLine(greeting + " " + Name);
    }
  }
}
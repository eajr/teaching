namespace dotnet.Models {
  using System;

  public class Player : Character {

    public Int16 Age;

    public string EyeColor;

    public Int16 Height;

    public void AskAge()
    {
      Console.WriteLine("Whats your age?");
      Age = Convert.ToInt16(Console.ReadLine());
    }
    
    public void AskName()
    {
      Console.WriteLine("Whats your name?");
      Name = Console.ReadLine();
    }
      public void GreetName(string greeting)
    {
      Console.WriteLine(greeting + " " + Name);
    }
      public void AgeCompare()
    {
      if (Age >= 30)
      {
        Console.WriteLine("Holy shit you're old");
      }
      else if (Age >= 18)
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
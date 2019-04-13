namespace dotnet.Models {
  using System;

  public class Player : Character {

    public Int16 Age;

    public string EyeColor;

    public Int16 Height;

    public void AskAge()
    {
      Console.WriteLine("Whats your age?");
      this.Age = Convert.ToInt16(Console.ReadLine());
    }
    
    public void AskName()
    {
      Console.WriteLine("Whats your name?");
      this.Name = Console.ReadLine();
    }
  }
}
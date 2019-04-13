namespace dotnet.Models {
  using System;

  public class Sword : Item {
    public Sword() {
      Durability = 1.0;
    }

    public int AttackPower;
    double Durability; // 1: start, 0: broken, every swing = -0.0001

    public void Swing() {
      Durability -= 0.0001;
    }

    public bool IsBroken() {
      return Durability <= 0;
    }
  }

}
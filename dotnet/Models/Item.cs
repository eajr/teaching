namespace dotnet.Models {
  using System;

  public class Item {
    public Item() {
      Rarity = ItemRarity.Common;
    }

    public string Name;
    public ItemRarity Rarity;

    public enum ItemRarity {
      Common,
      Uncommon,
      Rare,
      Legendary
    }
  }

}
using UnityEngine;
using System.Collections.Generic;

public class Inventory {
   
   private List<Item> itemList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Inventory() {
        itemList = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.GoldenKey, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Chest, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Crate, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Skull, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Potion, amount = 1});
    }

    public void AddItem(Item item) {
        itemList.Add(item);
    }
}

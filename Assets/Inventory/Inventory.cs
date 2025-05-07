using UnityEngine;
using System.Collections.Generic;

public class Inventory {
   
   private List<Item> itemList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Inventory() {
        itemList = new List<Item>();
       // AddItem(new Item { itemType = itemList.ItemType.GoldenKey, amount = 1});
    }

    public void AddItem(Item item) {
        itemList.Add(item);
    }
}

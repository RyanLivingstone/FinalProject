using UnityEngine;

public class Item {
    
    public enum ItemType {
        GoldenKey, Chest, Crate, Skull, Sword, Potion,
    }

    public ItemType itemType;
    public int amount;
}

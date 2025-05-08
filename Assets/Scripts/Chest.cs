using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject[] possibleLoot;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Chest triggered by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger was from Player");

            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
            if (playerInventory != null)
            {
                Debug.Log("PlayerInventory found. Has key? " + playerInventory.hasKey);

                if (playerInventory.hasKey)
                {
                    OpenChest();
                    playerInventory.hasKey = false;
                }
                else
                {
                    Debug.Log("Player does not have the key.");
                }
            }
            else
            {
                Debug.Log("PlayerInventory script not found on player.");
            }
        }
    }

    private void OpenChest()
    {
        Debug.Log("Opening chest...");
        
        if (possibleLoot.Length > 0)
        {
            int randomIndex = Random.Range(0, possibleLoot.Length);
            GameObject loot = Instantiate(possibleLoot[randomIndex], transform.position, Quaternion.identity);
            Debug.Log("Loot spawned: " + loot.name);
        }
        else
        {
            Debug.LogWarning("No possible loot available!");
        }

        Destroy(gameObject);
    }
}

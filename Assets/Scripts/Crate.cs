using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject swordPrefab;
    public GameObject skullPrefab;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if the player collided with the crate
        if (collider.CompareTag("Player"))
        {
            SmashCrate();
        }
    }

    private void SmashCrate()
    {
        Debug.Log("Crate smashed! Spawning item...");

        if (swordPrefab == null || skullPrefab == null)
        {
            Debug.LogError("Sword or Skull prefab is not assigned in the Inspector!");
            return;
        }

        GameObject itemToSpawn = Random.value > 0.5f ? swordPrefab : skullPrefab;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Instantiate(itemToSpawn, player.transform.position + Vector3.up * 1.5f, Quaternion.identity);
            Debug.Log("Item spawned: " + itemToSpawn.name);
        }
        else
        {
            Debug.LogError("Player object not found");
        }

        Destroy(gameObject);
    }
}

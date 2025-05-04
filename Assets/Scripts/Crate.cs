using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject swordPrefab;
    public GameObject skullPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SmashCrate();
        }
    }

    private void SmashCrate()
    {
        Debug.Log("Crate smashed! Spawning item...");

        GameObject itemToSpawn = Random.value > 0.5f ? swordPrefab : skullPrefab;

        Instantiate(itemToSpawn, transform.position + Vector3.up * 1.5f, Quaternion.identity);

        Destroy(gameObject);
    }
}


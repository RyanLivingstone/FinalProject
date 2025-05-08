using UnityEngine;

public class Collectibles : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect(other.gameObject);
            audioManager.PlaySFX(audioManager.ItemPickup);


        }
    }

    private void Collect(GameObject player)
    {
        Destroy(gameObject);
    }
}
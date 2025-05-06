using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Skull"))
        {
            Die();
        }

        else if (other.CompareTag("Food"))
        {
            RestoreHealth(2);
            Destroy(other.gameObject);
        }
    }

    public void RestoreHealth(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        Debug.Log("Health restored. Current health: " + currentHealth);
    }

    private void Die()
    {
        Debug.Log("Player died! Restarting scene...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
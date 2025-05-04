using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        Die();
    }
}


    private void Die()
    {
        Debug.Log("Player died! Restarting scene...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

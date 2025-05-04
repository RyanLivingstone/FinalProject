using UnityEngine;
using UnityEngine.SceneManagement;


public class Skull : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched skull. Restarting scene.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}


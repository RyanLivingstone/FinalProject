using UnityEngine;
using UnityEngine.SceneManagement;

public class Skull : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;  // Assign this in the Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched skull. Loading scene: " + sceneToLoad);
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.LogError("No scene name assigned to Skull script.");
            }
        }
    }
}

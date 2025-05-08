using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{   
    public string IntroScene = "";
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(IntroScene); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

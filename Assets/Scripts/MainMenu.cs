
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string IntroScene = "";
    public void PlayGame()
    {
        SceneManager.LoadScene(IntroScene);
    }
}

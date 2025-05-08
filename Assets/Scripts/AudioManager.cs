using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    [Header("------Audio Source------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
   

    [Header("------Audio Clip------")]
    public AudioClip EnemyDeath;
    public AudioClip EnemyMovement;
    public AudioClip SwordSound;
    public AudioClip ItemPickup;
    public AudioClip HeroDeath;
    public AudioClip GameplayMusic;
    public AudioClip IntroOutro;


    private void Start()
    {
        musicSource.clip = IntroOutro;
        musicSource.Play();
;
    }
}

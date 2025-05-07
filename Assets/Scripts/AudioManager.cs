using UnityEngine;

public class AudioManager : MonoBehaviour
{
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
}


using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header ("-------- Audio Clip --------")]
    public AudioClip background;
    public AudioClip dialogAdvance;
    public AudioClip button;

    private void Start()
    {
        musicSource.clip= background;
        musicSource.Play();
    }


}

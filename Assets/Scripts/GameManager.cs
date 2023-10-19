using UnityEngine;

public class GameManager : MonoBehaviour
{
[SerializeField]
AudioSource audioSource;

public AudioClip arkases;
    void Awake()
    {
        audioSource=GetComponent<AudioSource>();
    }

    void Start()
    {
        audioSource.PlayOneShot(arkases);
    }
}

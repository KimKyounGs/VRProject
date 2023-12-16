using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips = new AudioClip[3];
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[0];
        audioSource.Play();
    }
     
    void PlayAudio(int idx)
    {
        audioSource.clip = audioClips[idx];
        audioSource.Play();
    }
}

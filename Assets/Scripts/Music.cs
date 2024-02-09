using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClip;

    private bool isMusicPlaying = false;

    void Start()
    {
      
    }
    public void ButtonMusic()
    {
        musicSource.clip = musicClip;
        isMusicPlaying = false;
        if (isMusicPlaying)
        {
            musicSource.Stop();
        }
        else
        {
            musicSource.Play();
            isMusicPlaying = true;
        }

    }
    
     
}

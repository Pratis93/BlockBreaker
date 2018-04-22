using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource audio;

    public AudioClip bas;
    public AudioClip confirm;
    public AudioClip lostlive;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlayHit()
    {
        audio.clip = bas;
        audio.Play();
    }

    public void PlayDestroy()
    {
        audio.clip = confirm;
        audio.Play();
    }

    public void PlayLostLife()
    {
        audio.clip = lostlive;
        audio.Play();
    }

}

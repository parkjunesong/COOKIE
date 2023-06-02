using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public AudioClip[] sounds = new AudioClip[9];
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void _play(int i)
    {
        audio.PlayOneShot(sounds[i]);
    }
}


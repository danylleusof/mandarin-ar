using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    AudioSource fxSound;
    public AudioClip bgMusic;

    void Start()
    {
        fxSound = GetComponent<AudioSource>();
        fxSound.Play();
    }
}
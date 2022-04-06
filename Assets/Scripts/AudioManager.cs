using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager intance;

    public AudioSource[] soundEffects;

    private void Awake()
    {
        intance = this;
    }

    public void PlaySFX(int soundToPlay)
    {
        soundEffects[soundToPlay].Play();
    }
}

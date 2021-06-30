using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPageFX : MonoBehaviour
{
    public AudioSource playMusic;
    public AudioClip storeMusic;

    public void Sound()
    {
        playMusic.PlayOneShot(storeMusic);
    }
}

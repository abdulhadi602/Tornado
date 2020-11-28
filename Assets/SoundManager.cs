using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioSource[] Hits = new AudioSource[4];

    private static AudioSource Wind;
    private static AudioSource Win;

    private static AudioSource GameStartMusic;
    void Start()
    {
      AudioSource[]  Sounds = GetComponents<AudioSource>();
        Hits[0] = Sounds[0];
        Hits[1] = Sounds[1];
       
        Wind = Sounds[2];
        Win = Sounds[3];
        GameStartMusic = Sounds[4];
        GameStartMusic.Play();
    }
    public static void PlayHit()
    {
        Wind.Stop();
        Hits[Random.Range(0, 1)].Play();
    }
    public static void PlayWin()
    {
        Wind.Stop();
        Win.Play();
    }
    public static void PlayWind()
    {
        Wind.Play();
        GameStartMusic.Stop();
    }
}

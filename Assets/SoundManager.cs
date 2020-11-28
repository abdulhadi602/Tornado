using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioSource[] Hits = new AudioSource[4];

    private static AudioSource Wind;
    void Start()
    {
      AudioSource[]  Sounds = GetComponents<AudioSource>();
        Hits[0] = Sounds[0];
        Hits[1] = Sounds[1];
       
        Wind = Sounds[2];
        Wind.Play();
    }
    public static void PlayHit()
    {
        Wind.Stop();
        Hits[Random.Range(0, 1)].Play();
    }
 
}

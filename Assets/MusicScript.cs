using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioSource music;
    public static Boolean isPlaying = false;
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void playMusic()
    {
        music.Stop();
        music.Play();
        Debug.Log("Music played");
        isPlaying = true;
    }
}

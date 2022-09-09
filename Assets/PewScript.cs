using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PewScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static new AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playPewSound()
    {
        audio.PlayOneShot(audio.clip);
        Debug.Log("Pew played");
    }
}

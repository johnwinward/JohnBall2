using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space) && !ScoreScript.isScoreLocked)
        {
            if (!TimerScript.timerOn)
            {
                TimerScript.startTimer();
            }
            
            if (!MusicScript.isPlaying)
            {
                MusicScript.playMusic();
            }
            
        }
    }
}

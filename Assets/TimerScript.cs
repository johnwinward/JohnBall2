using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    const double TOTAL_TIME = 45.0;
    public static Text text;
    public static Boolean timerOn = false;
    public static double currentTime;
    public static double endTime;
    public static LayerMask visible;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        visible = LayerMask.NameToLayer("Sprites");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += (double) Time.deltaTime;
        if (timerOn)
        {
            text.text = "Time: " + (endTime - currentTime).ToString().Truncate(5, "");//(endTime - currentTime).ToString();
            if(currentTime >= endTime)
            {
                timerOn = false;
                text.text = "Time: 0.0";
                MusicScript.music.Stop();
                MusicScript.isPlaying = false;
                ScoreScript.isScoreLocked = true;
                ResetScript.text.text = "Please Insert Quarter (Or Press Enter)";
            }
        }
    }

    public static void startTimer()
    {
        currentTime = Time.timeAsDouble;
        endTime = currentTime + TOTAL_TIME;
        text.text = "Time: " + (endTime - currentTime).ToString();
        ScoreScript.isScoreLocked = false;
        ScoreScript.resetScore();
        timerOn = true;
    }
}

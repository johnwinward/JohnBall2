using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static Text text;
    public static int score;
    public static Boolean isScoreLocked = false;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = GetComponent<Text>();
        text.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void updateScore()
    {
        if (!isScoreLocked)
        {
            score++;
            text.text = "Score: " + score.ToString();
        }
  
    }

    public static void resetScore()
    {
        score = 0;
        text.text = "Score: " + score.ToString();
    }
}

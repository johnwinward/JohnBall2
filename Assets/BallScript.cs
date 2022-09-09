using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Boolean inTimeout;
    double timer;
    System.Random random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        inTimeout = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inTimeout && Time.timeAsDouble >= timer + (random.NextDouble() * (25.0 - 5.0) + 5.0))
        {
            spriteRenderer.enabled = true;
            inTimeout = false;
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.enabled = false;
        inTimeout = true;
        timer = Time.timeAsDouble;
        GetComponent<BoxCollider2D>().enabled = false;
        ScoreScript.updateScore();
    }

}

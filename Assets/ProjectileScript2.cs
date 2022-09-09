using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class ProjectileScript2 : MonoBehaviour
{
    Boolean isLaunched = false;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //hiddenLayer = LayerMask.NameToLayer("Collider");
        //visibleLayer = LayerMask.NameToLayer("Sprites");
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isLaunched)
        {
            if (ProjectileScript.isLaunched)
            {
                PewScript.playPewSound();
                spriteRenderer.enabled = true;
                transform.position = GameObject.Find("Hero").transform.position + new Vector3(0, 1);
                isLaunched = true;

                if (isLaunched)
                {
                    transform.position += Vector3.up * 20 * Time.deltaTime;
                }
            }
        }

        if (isLaunched)
        {
            transform.position += Vector3.up * 20 * Time.deltaTime;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.enabled = false;
        isLaunched = false;
    }
}

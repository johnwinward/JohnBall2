using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScript : MonoBehaviour
{
    public static Text text;
    // Start is called before the first frame update
    void Start()
    {

        text = GetComponent<Text>();
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            text.text = "";
            ScoreScript.resetScore();
            ScoreScript.isScoreLocked = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndScore : MonoBehaviour
{
    Text text;
    static public float secs;


    void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = "0";

    }

    void Update()
    {
        // Press the space key to change the Text message.
        if (text.tag == "score")
        {
            text.text = "Score: " + GameObject.Find("BrickManager").GetComponent<BrickInputs>().brickCount;
        }
        secs += Time.deltaTime;
        if (text.tag == "timer")
        {
            text.text = secs.ToString("#.0");
        }
    }
}

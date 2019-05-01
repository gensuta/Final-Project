using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndScore : MonoBehaviour
{
    Text text;
    static public float timeLeft = 30;
    public int round;


    void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = "0";

    }

    void Update()
    {
        if (round == 1)
        {
            Time.timeScale = 1f;
        }

        if (round == 2)
        {
            Time.timeScale = 2f;

        }

        if (round == 3)
        {
            Time.timeScale = 3f;
        }


        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && text.tag == "timer")
        {
            text.text = "game over";
        }

        // Press the space key to change the Text message.
        if (text.tag == "brick")
        {
            text.text = "Score: " + GameObject.Find("BrickManager").GetComponent<BrickInputs>().brickCount;
        }

        if (text.tag == "apple")
        {
            text.text = "Score: " + GameObject.Find("hands").GetComponent<handController>().numCaught;
        }

        if (text.tag == "timer")
        {
            text.text = timeLeft.ToString("#.0");
        }
    }
}

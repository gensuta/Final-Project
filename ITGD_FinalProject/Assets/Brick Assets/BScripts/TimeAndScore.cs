using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndScore : MonoBehaviour
{
    Text text;
    public int round;
    //the static timeLeft was moved to the gameController since gameController is in every scene
    // meaning it can also be reset during the stats screen

    void Start()
    {
        round = gameController.instance.rounds;
        text = gameObject.GetComponent<Text>();
        text.text = "0";

    }

    void Update()
    {
        if (round == 0) // first round
        {
            Time.timeScale = 1f;
        }

        if (round == 1) // second
        {
            Time.timeScale = 2f;

        }

        if (round == 2) // third
        {
            Time.timeScale = 3f;
        }


        gameController.instance.timeLeft -= Time.deltaTime;
        if (gameController.instance.timeLeft < 0 && text.tag == "timer")
        {
            gameController.instance.GoToStats();
            text.text = "game over";
        }

        // Press the space key to change the Text message.
        if (text.tag == "brick")
        {
            text.text = "Score: " + gameController.instance.bricksDown;
        }

        if (text.tag == "apple")
        {
            text.text = "Score: " + gameController.instance.applesCaught;
        }

        if (text.tag == "tree")
        {
            text.text = "Score: " + gameController.instance.woodCut;
        }

        if (text.tag == "timer")
        {
            text.text = gameController.instance.timeLeft.ToString("#.0");
        }
    }
}

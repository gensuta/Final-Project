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

    void Awake()
    {
        round = gameController.instance.rounds;
        text = gameObject.GetComponent<Text>();
    }

    void Start()
    {
        {
            this.text.text = "0";
        }
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

        // Press the space key to change the Text message.
        if (this.text.tag == "brick")
        {
            this.text.text = "Score: " + gameController.instance.bricksDown;
        }

        if (this.text.tag == "apple")
        {
            this.text.text = "Score: " + gameController.instance.applesCaught;
        }

        if (this.text.tag == "tree")
        {
            this.text.text = "Score: " + gameController.instance.woodCut;
        }

        if (this.text.tag == "brickf")
        {
            this.text.text = "Total Bricks: " + gameController.instance.storedBricks;
        }

        if (this.text.tag == "applef")
        {
            this.text.text = "Total Apples: " + gameController.instance.storedApples;
        }

        if (this.text.tag == "treef")
        {
            this.text.text = "Total Trees: " + gameController.instance.storedWood;
        }

        if (this.text.tag == "timer")
        {
            this.text.text = "Time: " + gameController.instance.timeLeft.ToString("#.0");
        }

        if (this.text.tag == "round")
        {
            this.text.text = "Round: " + (round + 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndScore : MonoBehaviour
{
    Text text;
    Image image;
    public Sprite tree;
    public Sprite brick;
    public Sprite apple;
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

        if (gameController.instance.currentScene == 1)
        {
            if (this.text.tag == "brick" || this.text.tag == "apple")
            {
                this.text.tag = "tree";
            }
            if (this.image.tag == "brick" || this.image.tag == "apple")
            {
                this.image.tag = "tree";
            }
        }

        if (gameController.instance.currentScene == 2)
        {
            if (this.text.tag == "tree" || this.text.tag == "apple")
            {
                this.text.tag = "brick";
            }
            if (this.image.tag == "tree" || this.image.tag == "apple")
            {
                this.image.tag = "brick";
            }
        }

        if (gameController.instance.currentScene == 3)
        {
            if (this.text.tag == "brick" || this.text.tag == "tree")
            {
                this.text.tag = "apple";
            }
            if (this.image.tag == "brick" || this.image.tag == "tree")
            {
                this.image.tag = "apple";
            }
        }

        if (this.image.tag == "tree")
        {
            image.sprite = tree;
        }

        if (this.image.tag == "brick")
        {
            image.sprite = brick;
        }

        if (this.image.tag == "apple")
        {
            image.sprite = apple;
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

        if (text.tag == "brickf")
        {
            text.text = "Total Bricks: " + gameController.instance.storedBricks;
        }

        if (text.tag == "applef")
        {
            text.text = "Total Apples: " + gameController.instance.storedApples;
        }

        if (text.tag == "treef")
        {
            text.text = "Total Trees: " + gameController.instance.storedWood;
        }

        if (text.tag == "timer")
        {
            text.text = "Time: " + gameController.instance.timeLeft.ToString("#.0");
        }
    }
}

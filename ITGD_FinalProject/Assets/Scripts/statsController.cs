using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class statsController : MonoBehaviour
{

    public Text theText;
    public bool didAdd; //did add to the stored score

    public bool showInstructions; //are they being shown?
    public Sprite[] sprites; //0 is wood

    public Image img;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        if (gameController.instance.currentScene < 4)
        {
            gameController.instance.numGames += 1;

            if (gameController.instance.rounds >= 4)
            {
                theText.text = "Game Over!";
                gameController.instance.currentScene = 5;
            }
            else if (gameController.instance.numGames == 3 && gameController.instance.rounds < 4)
            {
                theText.text = "Things are going to get faster! \n";
                gameController.instance.rounds += 1;
                gameController.instance.numGames = 0;
            }
            else
            {
                theText.text = "";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!didAdd && gameController.instance.rounds < 4) // storing total thing collected
        {
            if (gameController.instance.lastGame == 1) //wood
            {
                theText.text += "You cut " + gameController.instance.woodCut.ToString() + " trees!";
                gameController.instance.storedWood += gameController.instance.woodCut;
               
            }


            else if (gameController.instance.lastGame == 2) //brick
            {
                theText.text += "You stacked " + gameController.instance.bricksDown.ToString() + " bricks!";

                gameController.instance.storedBricks += gameController.instance.bricksDown;
            }

            else if (gameController.instance.lastGame == 3) //fruit
            {
                theText.text += "You caught " + gameController.instance.applesCaught.ToString() + " apples!";

                gameController.instance.storedApples += gameController.instance.applesCaught;
            }
            else
            {
                theText.text = "";

            }



            didAdd = true;
        }


        if (showInstructions || gameController.instance.rounds > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space) && gameController.instance.rounds <= 2)
            {
                gameController.instance.ProgressScene();

            }

            if (Input.GetKeyDown(KeyCode.Space) && gameController.instance.rounds >= 3)
            {

                gameController.instance.FinalScene();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || gameController.instance.lastGame > 3)
            {

                if (gameController.instance.lastGame >= 3) // go to tree img
                {
                    img.sprite = sprites[0];
                }

                if (gameController.instance.lastGame == 1) // brick
                {
                    img.sprite = sprites[1];
                }

                if (gameController.instance.lastGame == 2) // apple
                {
                    img.sprite = sprites[2];
                }

                anim.SetBool("appear",true);

                showInstructions = true;
            }
        }
    }
}

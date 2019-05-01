using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class statsController : MonoBehaviour
{

    public Text theText;
    // Start is called before the first frame update
    void Start()
    {
        gameController.instance.numGames += 1;
        if (gameController.instance.numGames == 3)
        {
            gameController.instance.rounds += 1;
            gameController.instance.numGames = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameController.instance.lastGame == 1) //wood
        {
           theText.text = "You cut " + gameController.instance.woodCut.ToString() + " trees!";
        }
        if (gameController.instance.lastGame == 2) //brick
        {
            theText.text = "You stacked " + gameController.instance.bricksDown.ToString() + " bricks!";
        }
        if (gameController.instance.lastGame == 3) //fruit
        {
            theText.text = "You caught " + gameController.instance.applesCaught.ToString() + " apples!";
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameController.instance.rounds == 0)
            {
                gameController.instance.ForwardAScene();
            }
            else
            {
                SceneManager.LoadScene(gameController.instance.RandomScene());
            }
        }
    }
}

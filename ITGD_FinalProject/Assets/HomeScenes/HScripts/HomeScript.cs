using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite bad;
    public Sprite good;
    public Sprite great;
    //public int extraRes;
    //public int newWood;
    //public int newBricks;
    //public int newApples;
    public int totalRes;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        House();
        //newWood = gameController.instance.storedWood;
        //newApples = gameController.instance.storedApples;
        //newBricks = gameController.instance.storedBricks;

        //if (gameController.instance.storedWood >= 110)
        //{
        //    if (gameController.instance.storedWood > 110)
        //    {
        //        extraRes += (gameController.instance.storedWood - 110);
        //    }
        //}

        //if (gameController.instance.storedBricks >= 35)
        //{
        //    if (gameController.instance.storedBricks > 35)
        //    {
        //        extraRes += (gameController.instance.storedBricks - 35);
        //    }
        //}

        //if (gameController.instance.storedApples >= 60)
        //{
        //    if (gameController.instance.storedApples > 60)
        //    {
        //        extraRes += (gameController.instance.storedApples - 60);
        //    }
        //}

        //if (gameController.instance.storedWood <= 110 && extraRes > 0)
        //{
        //    for (int i = gameController.instance.storedWood; i < 110; i++)
        //    {
        //        newWood += 1;
        //        extraRes -= 1;
        //    }
        //}

        //if (gameController.instance.storedBricks <= 35 && extraRes > 0)
        //{
        //    for (int i = gameController.instance.storedWood; i < 110; i++)
        //    {
        //        newWood += 1;
        //        extraRes -= 1;
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space)) //to restart the game
        {
            gameController.instance.ResetGame();
        }
    }

    public void House()
    {
        totalRes = gameController.instance.storedApples + gameController.instance.storedBricks + gameController.instance.storedWood;

        if (totalRes >= 200)
        {
            sr.sprite = great;
        }

        if (totalRes < 100 && totalRes > 200)
        {
            sr.sprite = good;
        }

        if (totalRes <= 100)
        {
            sr.sprite = bad;
        }

    }

}

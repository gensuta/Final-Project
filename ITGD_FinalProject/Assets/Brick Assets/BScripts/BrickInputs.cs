using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickInputs : MonoBehaviour
{
    public int phase = 1;
    public bool isTop = true;
    public bool brickDone = true;
    public GameObject Brick;
    public int brickCount;
    public Vector3 newPos;

    public int topRow;
    public int botRow;
    public int submitB;

    // Start is called before the first frame update
    void Start()
    {
        brickCount = 0;
        CutWood();
    }

    // Update is called once per frame
    void Update()
    {

        if (topRow == 1 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha1))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 1 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.Q))
            {
                phase = 3;
            }
        }

        if (topRow == 2 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha2))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 2 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.W))
            {
                phase = 3;
            }
        }

        if (topRow == 3 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha3))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 3 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.E))
            {
                phase = 3;
            }
        }

        if (topRow == 4 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha4))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 4 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.R))
            {
                phase = 3;
            }
        }

        if (topRow == 5 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha5))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 5 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.T))
            {
                phase = 3;
            }
        }

        if (topRow == 6 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha6))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 6 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.Y))
            {
                phase = 3;
            }
        }

        if (topRow == 7 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha7))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 7 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.U))
            {
                phase = 3;
            }
        }

        if (topRow == 8 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha8))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 8 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.I))
            {
                phase = 3;
            }
        }

        if (topRow == 9 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha9))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 9 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.O))
            {
                phase = 3;
            }
        }

        if (topRow == 0 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Alpha0))
            {
                phase = 2;
                isTop = false;
                botRow = topRow;
            }
        }
        if (botRow == 0 && !isTop)
        {
            if (phase == 2 && Input.GetKeyDown(KeyCode.P))
            {
                phase = 3;
            }
        }

        if (phase == 3 && Input.GetMouseButtonDown(submitB))
        {
            brickCount++;
            gameController.instance.bricksDown = brickCount;
            CutWood();
            
        }

    }

    void CutWood()
    {
        float bC = (float)brickCount;
        float nextBrick = Brick.GetComponent<BoxCollider2D>().size.x;
        Debug.Log("bC: " + bC);
        Debug.Log("nextBrick: " + nextBrick);
        newPos = new Vector3(0 + (bC * nextBrick * 15), -1.5f);
        topRow = Random.Range(0, 11);
        submitB = Random.Range(0, 2);
        Instantiate(Brick, newPos, Quaternion.identity);
        phase = 1;
        isTop = true;
    }
}

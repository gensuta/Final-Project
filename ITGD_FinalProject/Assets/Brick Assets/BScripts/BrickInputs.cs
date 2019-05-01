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

    // Start is called before the first frame update
    void Start()
    {
        brickCount = 0;
        CutWood();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (topRow == 0 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Q))
            {
                phase = 2; 
            }
            if (phase == 2 && isTop && Input.GetKeyDown(KeyCode.W))
            {
                phase = 3;
            }
            if (phase == 3 && isTop && Input.GetKeyDown(KeyCode.E))
            {
                phase = 4;
                isTop = false;
            }
        }
        if (topRow == 1 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.I))
            {
                phase = 2;
            }
            if (phase == 2 && isTop && Input.GetKeyDown(KeyCode.O))
            {
                phase = 3;
            }
            if (phase == 3 && isTop && Input.GetKeyDown(KeyCode.P))
            {
                phase = 4;
                isTop = false;
            }
        }
        if (topRow == 2 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.Z))
            {
                phase = 2;
            }
            if (phase == 2 && isTop && Input.GetKeyDown(KeyCode.X))
            {
                phase = 3;
            }
            if (phase == 3 && isTop && Input.GetKeyDown(KeyCode.C))
            {
                phase = 4;
                isTop = false;
            }
        }
        if (topRow == 3 && isTop)
        {
            if (phase == 1 && isTop && Input.GetKeyDown(KeyCode.B))
            {
                phase = 2;
            }
            if (phase == 2 && isTop && Input.GetKeyDown(KeyCode.N))
            {
                phase = 3;
            }
            if (phase == 3 && isTop && Input.GetKeyDown(KeyCode.M))
            {
                phase = 4;
            }
        }

        if (phase == 4 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            isTop = false;
            phase = 5;
        }

        if (botRow == 0 && !isTop)
        {
            if (phase == 5 && !isTop && Input.GetKeyDown(KeyCode.Q))
            {
                phase = 6;
            }
            if (phase == 6 && !isTop && Input.GetKeyDown(KeyCode.W))
            {
                phase = 7;
            }
            if (phase == 7 && !isTop && Input.GetKeyDown(KeyCode.E))
            {
                phase = 8;
            }
        }
        if (botRow == 1 && !isTop)
        {
            if (phase == 5 && !isTop && Input.GetKeyDown(KeyCode.I))
            {
                phase = 6;
            }
            if (phase == 6 && !isTop && Input.GetKeyDown(KeyCode.O))
            {
                phase = 7;
            }
            if (phase == 7 && !isTop && Input.GetKeyDown(KeyCode.P))
            {
                phase = 8;
            }
        }
        if (botRow == 2 && !isTop)
        {
            if (phase == 5 && !isTop && Input.GetKeyDown(KeyCode.Z))
            {
                phase = 6;
            }
            if (phase == 6 && !isTop && Input.GetKeyDown(KeyCode.X))
            {
                phase = 7;
            }
            if (phase == 7 && !isTop && Input.GetKeyDown(KeyCode.C))
            {
                phase = 8;
            }
        }
        if (botRow == 3 && !isTop)
        {
            if (phase == 5 && !isTop && Input.GetKeyDown(KeyCode.B))
            {
                phase = 6;
            }
            if (phase == 6 && !isTop && Input.GetKeyDown(KeyCode.N))
            {
                phase = 7;
            }
            if (phase == 7 && !isTop && Input.GetKeyDown(KeyCode.M))
            {
                phase = 8;
            }
        }

        if (phase == 8 && Input.GetKeyDown(KeyCode.Space))
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
        topRow = Random.Range(0, 4);
        botRow = Random.Range(0, 4);
        Instantiate(Brick, newPos, Quaternion.identity);
        phase = 1;
        isTop = true;
    }
}

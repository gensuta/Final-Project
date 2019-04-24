using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickInputs : MonoBehaviour
{
    public int phase = 1;
    public bool isTop = true;
    public bool brickDone = true;

    public int topRow;
    public int botRow;

    // Start is called before the first frame update
    void Start()
    {
        topRow = Random.Range(0, 3);
        botRow = Random.Range(0, 3);
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

    }

    void CutWood()
    {
        topRow = Random.Range(0, 3);
        botRow = Random.Range(0, 3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlace : MonoBehaviour
{
    BrickInputs bri;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        bri = FindObjectOfType<BrickInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bri.phase == 3)
        {
            if (bri.submitB == 0)
            {
                text.text = "Left Click";
            }

            if (bri.submitB == 1)
            {
                text.text = "Right Click";
            }
        }


        if (bri.topRow == 0 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "0";
        }
        if (bri.topRow == 1 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "1";
        }
        if (bri.topRow == 2 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "2";
        }
        if (bri.topRow == 3 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "3";
        }
        if (bri.topRow == 4 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "4";
        }
        if (bri.topRow == 5 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "5";
        }
        if (bri.topRow == 6 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "6";
        }
        if (bri.topRow == 7 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "7";
        }
        if (bri.topRow == 8 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "8";
        }
        if (bri.topRow == 9 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "9";
        }


        if (bri.botRow == 0 && !bri.isTop && bri.phase == 2)
        {
            text.text = "P";
        }
        if (bri.botRow == 1 && !bri.isTop && bri.phase == 2)
        {
            text.text = "Q";
        }
        if (bri.botRow == 2 && !bri.isTop && bri.phase == 2)
        {
            text.text = "W";
        }
        if (bri.botRow == 3 && !bri.isTop && bri.phase == 2)
        {
            text.text = "E";
        }
        if (bri.botRow == 4 && !bri.isTop && bri.phase == 2)
        {
            text.text = "R";
        }
        if (bri.botRow == 5 && !bri.isTop && bri.phase == 2)
        {
            text.text = "T";
        }
        if (bri.botRow == 6 && !bri.isTop && bri.phase == 2)
        {
            text.text = "Y";
        }
        if (bri.botRow == 7 && !bri.isTop && bri.phase == 2)
        {
            text.text = "U";
        }
        if (bri.botRow == 8 && !bri.isTop && bri.phase == 2)
        {
            text.text = "I";
        }
        if (bri.botRow == 9 && !bri.isTop && bri.phase == 2)
        {
            text.text = "O";
        }
    }
}

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
        if (bri.phase == 4)
        {
            text.text = "DOWN";
        }

        if (bri.phase == 8)
        {
            text.text = "SPACE";
        }

        if (bri.topRow == 0 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "Q W E";
        }
        if (bri.topRow == 0 && bri.isTop == true && bri.phase == 2)
        {
            text.text = "W E";
        }
        if (bri.topRow == 0 && bri.isTop == true && bri.phase == 3)
        {
            text.text = "E";
        }


        if (bri.topRow == 1 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "I O P";
        }
        if (bri.topRow == 1 && bri.isTop == true && bri.phase == 2)
        {
            text.text = "O P";
        }
        if (bri.topRow == 1 && bri.isTop == true && bri.phase == 3)
        {
            text.text = "P";
        }


        if (bri.topRow == 2 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "Z X C";
        }
        if (bri.topRow == 2 && bri.isTop == true && bri.phase == 2)
        {
            text.text = "X C";
        }
        if (bri.topRow == 2 && bri.isTop == true && bri.phase == 3)
        {
            text.text = "C";
        }


        if (bri.topRow == 3 && bri.isTop == true && bri.phase == 1)
        {
            text.text = "B N M";
        }
        if (bri.topRow == 3 && bri.isTop == true && bri.phase == 2)
        {
            text.text = "N M";
        }
        if (bri.topRow == 3 && bri.isTop == true && bri.phase == 3)
        {
            text.text = "M";
        }

        if (bri.botRow == 0 && !bri.isTop && bri.phase == 5)
        {
            text.text = "Q W E";
        }
        if (bri.botRow == 0 && !bri.isTop && bri.phase == 6)
        {
            text.text = "W E";
        }
        if (bri.botRow == 0 && !bri.isTop && bri.phase == 7)
        {
            text.text = "E";
        }


        if (bri.botRow == 1 && !bri.isTop && bri.phase == 5)
        {
            text.text = "I O P";
        }
        if (bri.botRow == 1 && !bri.isTop && bri.phase == 6)
        {
            text.text = "O P";
        }
        if (bri.botRow == 1 && !bri.isTop && bri.phase == 7)
        {
            text.text = "P";
        }


        if (bri.botRow == 2 && !bri.isTop && bri.phase == 5)
        {
            text.text = "Z X C";
        }
        if (bri.botRow == 2 && !bri.isTop && bri.phase == 6)
        {
            text.text = "X C";
        }
        if (bri.botRow == 2 && !bri.isTop && bri.phase == 7)
        {
            text.text = "C";
        }


        if (bri.botRow == 3 && !bri.isTop && bri.phase == 5)
        {
            text.text = "B N M";
        }
        if (bri.botRow == 3 && !bri.isTop && bri.phase == 6)
        {
            text.text = "N M";
        }
        if (bri.botRow == 3 && !bri.isTop && bri.phase == 7)
        {
            text.text = "M";
        }
    }
}

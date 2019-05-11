using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlace : MonoBehaviour
{
    BrickInputs bri;
    Image image;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite zero;
    public Sprite onePressed;
    public Sprite twoPressed;
    public Sprite threePressed;
    public Sprite fourPressed;
    public Sprite fivePressed;
    public Sprite sixPressed;
    public Sprite sevenPressed;
    public Sprite eightPressed;
    public Sprite ninePressed;
    public Sprite zeroPressed;
    public Sprite q;
    public Sprite w;
    public Sprite e;
    public Sprite r;
    public Sprite t;
    public Sprite y;
    public Sprite u;
    public Sprite i;
    public Sprite o;
    public Sprite p;
    public Sprite qPressed;
    public Sprite wPressed;
    public Sprite ePressed;
    public Sprite rPressed;
    public Sprite tPressed;
    public Sprite yPressed;
    public Sprite uPressed;
    public Sprite iPressed;
    public Sprite oPressed;
    public Sprite pPressed;
    public Sprite lc;
    public Sprite rc;




    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        bri = FindObjectOfType<BrickInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bri.submitB == 0)
        {
            if (this.image.tag == "input3")
            {
                image.sprite = lc;
            }
        }

        if (bri.submitB == 1)
        {
            if (this.image.tag == "input3")
            {
                image.sprite = rc;
            }
        }


        if (bri.topRow == 0 && bri.isTop == true && bri.phase == 1)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = zero;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = p;
            }
        }

        if (bri.phase == 1)
        {
            if (bri.topRow == 1 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = one;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = q;
                }
            }
            if (bri.topRow == 2 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = two;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = w;
                }
            }
            if (bri.topRow == 3 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = three;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = e;
                }
            }
            if (bri.topRow == 4 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = four;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = r;
                }
            }
            if (bri.topRow == 5 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = five;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = t;
                }
            }
            if (bri.topRow == 6 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = six;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = y;
                }
            }
            if (bri.topRow == 7 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = seven;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = u;
                }
            }
            if (bri.topRow == 8 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = eight;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = i;
                }
            }
            if (bri.topRow == 9 && bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = nine;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = o;
                }
            }
        }




        if (bri.phase == 2) {

            if (bri.topRow == 0 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = zeroPressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = p;
                }
            }
            if (bri.topRow == 1 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = onePressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = q;
                }
            }
            if (bri.topRow == 2 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = twoPressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = w;
                }
            }
            if (bri.topRow == 3 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = threePressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = e;
                }
            }
            if (bri.topRow == 4 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = fourPressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = r;
                }
            }
            if (bri.topRow == 5 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = fivePressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = t;
                }
            }
            if (bri.topRow == 6 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = sixPressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = y;
                }
            }
            if (bri.topRow == 7 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = sevenPressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = u;
                }
            }
            if (bri.topRow == 8 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = eightPressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = i;
                }
            }
            if (bri.topRow == 9 && !bri.isTop == true)
            {
                if (this.image.tag == "input1")
                {
                    image.sprite = ninePressed;
                }
                if (this.image.tag == "input2")
                {
                    image.sprite = o;
                }
            }
        }

        if(bri.phase == 3)
        { 
        if (bri.topRow == 0)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = zeroPressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = pPressed;
            }
        }
        if (bri.topRow == 1)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = onePressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = qPressed;
            }
        }
        if (bri.topRow == 2)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = twoPressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = wPressed;
            }
        }
        if (bri.topRow == 3)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = threePressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = ePressed;
            }
        }
        if (bri.topRow == 4)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = fourPressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = rPressed;
            }
        }
        if (bri.topRow == 5)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = fivePressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = tPressed;
            }
        }
        if (bri.topRow == 6)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = sixPressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = yPressed;
            }
        }
        if (bri.topRow == 7)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = sevenPressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = uPressed;
            }
        }
        if (bri.topRow == 8)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = eightPressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = iPressed;
            }
        }
        if (bri.topRow == 9)
        {
            if (this.image.tag == "input1")
            {
                image.sprite = ninePressed;
            }
            if (this.image.tag == "input2")
            {
                image.sprite = oPressed;
            }
        }
    }
    }
}

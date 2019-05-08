using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleManager : MonoBehaviour
{

    public float timer;
    public float waitTime; // the time between each apple falls down
    public GameObject apple;
    public GameObject pineCone;
    public float resetNum; // time gets reset to this number
    public float originalRestNum;
    public float pineConeWaitTime;
    public float pineResetNum;
  

    handController hc;

    // Start is called before the first frame update
    void Start()
    {
        hc = FindObjectOfType<handController>();
      
        originalRestNum = resetNum;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        waitTime -= Time.deltaTime;
        pineConeWaitTime -= Time.deltaTime;

        if(timer > 0f)
        {
            if (waitTime <= 0)
            {
                int x = Random.Range(-8, 8); //getting random X pos!

                Vector3 randomPos = new Vector3(x, 6, 0f);
                Instantiate(apple, randomPos, Quaternion.identity);
               
                resetNum = originalRestNum -= (hc.combo * .02f);

                if(resetNum < -5f)
                {
                    resetNum = 1f;
                }

                waitTime = resetNum;
         
            }
            if (pineConeWaitTime <= 0)
            {
                int x2 = Random.Range(-8, 8);
                Vector3 randomPos2 = new Vector3(x2, 6, 0f);
                Instantiate(pineCone, randomPos2, Quaternion.identity);

                if (pineResetNum < -5f)
                {
                    pineResetNum = 1f;
                }
                pineConeWaitTime = pineResetNum;
            }
        }
        else
        {
            gameController.instance.GoToStats();
        }
    }
}

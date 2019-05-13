using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleManager : MonoBehaviour
{
    public float waitTime; // the time between each apple falls down
    public GameObject apple;
    public GameObject pineCone;
    public float resetNum; // time gets reset to this number
    public float originalRestNum;
    public float pineConeWaitTime;
    public float pineResetNum;

    public AudioClip fallSnd;
  

    handController hc;

    // Start is called before the first frame update
    void Start()
    {
        hc = FindObjectOfType<handController>();
        pineConeWaitTime = Random.Range(0.2f, 2.5f);
        originalRestNum = resetNum;
    }

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;
        pineConeWaitTime -= Time.deltaTime;

        if(gameController.instance.timeLeft > 0f)
        {
            if (waitTime <= 0) // for instantiating an apple!
            {
                int x = Random.Range(-8, 8); //getting random X pos!

                Vector3 randomPos = new Vector3(x, 6, 0f);
                Instantiate(apple, randomPos, Quaternion.identity);
                AudioSource.PlayClipAtPoint(fallSnd, Vector3.zero, 0.5f);
               
                resetNum = originalRestNum -= (hc.combo * .025f);

                if(resetNum < -1.5f)
                {
                    resetNum = 1f;
                }

                waitTime = resetNum;
         
            }
            if (pineConeWaitTime <= 0) // for spawning a pine cone
            {
                int x2 = Random.Range(-8, 8);
                Vector3 randomPos2 = new Vector3(x2, 6, 0f);
                Instantiate(pineCone, randomPos2, Quaternion.identity);
                AudioSource.PlayClipAtPoint(fallSnd, Vector3.zero, 0.5f);

                if (pineResetNum < -5f)
                {
                    pineResetNum = 1f;
                }
                pineConeWaitTime = Random.Range(0.2f, 2.5f);
            }
        }
        else
        {
            gameController.instance.GoToStats();
        }
    }
}

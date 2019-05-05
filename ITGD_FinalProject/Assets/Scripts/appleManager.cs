using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class appleManager : MonoBehaviour
{

    public float timer;
    public float waitTime; // the time between each apple falls down
    public GameObject apple;
    public float resetNum; // time gets reset to this number
    public float originalRestNum;

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

                Debug.Log(resetNum);
                waitTime = resetNum;
            }
        }
        else
        {
            SceneManager.LoadScene("StatsScreen");
        }
    }
}

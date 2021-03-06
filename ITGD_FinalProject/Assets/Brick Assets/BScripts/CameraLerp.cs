﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{  
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (this.gameObject.tag == "brickani")
        {
            Vector3 position = this.transform.position;
            float interpolation = speed * Time.deltaTime;
            position.x = Mathf.Lerp((this.transform.position.x), GameObject.Find("BrickManager").GetComponent<BrickInputs>().newPos.x, interpolation);
            this.transform.position = position;
        }

        else
        {
            Vector3 position = this.transform.position;
            float interpolation = speed * Time.deltaTime;
            position.x = Mathf.Lerp((this.transform.position.x), GameObject.Find("BrickManager").GetComponent<BrickInputs>().newPos.x + 5.1f, interpolation);
            this.transform.position = position;
        }
    }
}

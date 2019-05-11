using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleScript : MonoBehaviour
{
    handController hc;

    // Start is called before the first frame update
    void Start()
    {
        hc = FindObjectOfType<handController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            hc.combo = 0;
            Destroy(gameObject, 0.2f);
        }
    }
}

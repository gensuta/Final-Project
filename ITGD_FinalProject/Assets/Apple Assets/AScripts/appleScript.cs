using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleScript : MonoBehaviour
{
    handController hc;
    Rigidbody2D rb;
    CircleCollider2D cc;
    Animator anim;

    public AudioClip missSound;

    bool didRoll; // did the autobots roll out? ( this bool is to keep the audio from playing more than once)

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
        anim = GetComponent<Animator>();

        hc = FindObjectOfType<handController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -4.6f)
        {
            if (!didRoll)
            {
                rb.gravityScale = 0f;
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                if (cc != null)
                {
                    cc.enabled = false;
                }

                AudioSource.PlayClipAtPoint(missSound, Vector3.zero, 1f);

                anim.SetTrigger("breakTrigger");
                hc.combo = 0;
                Destroy(gameObject, 2f);

                didRoll = true;
            }
        }
    }
}

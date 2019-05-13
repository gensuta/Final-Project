using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handController : MonoBehaviour
{
    public AudioClip catchSound;
    public AudioClip hitSound; // when you get hit by a pinecone

    public GameObject particles;


    public GameObject player;
    SpriteRenderer playerSprite;
    public int numCaught;
    public float timer;

    public float crashTimer;
    public float waitTime = 1f;
    public bool justCol;
    public bool playerMove = true;
    public bool gotHit = false;

    Animator m_Animator;
    public Sprite down;
    public int combo; //checking how many u caught in succession!

    // Start is called before the first frame update
    void Start()
    {
        playerSprite = player.GetComponent<SpriteRenderer>();
        m_Animator = GetComponent<Animator>();
        playerMove = true;
        waitTime = 1;
        gotHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove)
        {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //getting where your mouse is in the actual game
            Vector2 mousePos2D = new Vector2(mousePos.x, transform.position.y); // turning that vector 3 into a vector 2 for raycasting sake                                                                     //THE TWIST IS THE Y CAN'T GO UP OR DOWN!! which is why i did ^^

            transform.position = mousePos2D;
        }

        if (gotHit)
        {
            crashTimer += Time.deltaTime;
            playerMove = false;
            justCol = true;

            if (crashTimer > waitTime)
            {
                crashTimer = 0f;
                playerMove = true;
                justCol = false;
                gotHit = false;
                m_Animator.SetBool("gotHit", false);
            }

        }

        if (justCol == true && crashTimer >= .2f)
        {
            m_Animator.SetBool("gotHit", true);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "pinecone")
        {
            if (numCaught > 0)
            {
                numCaught -= 1;
            }
            gotHit = true;

            AudioSource.PlayClipAtPoint(hitSound, Vector3.zero, 1f);
        }

        else
        {
            //when you catch an apple, the particle system shows up!
            Instantiate(particles, player.transform.position, Quaternion.identity);
            numCaught += 1;
            combo += 1;

            AudioSource.PlayClipAtPoint(catchSound, Vector3.zero, 1f);
        }

        gameController.instance.applesCaught = numCaught;
        Destroy(collision.gameObject);
    }
}

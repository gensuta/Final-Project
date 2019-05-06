using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handController : MonoBehaviour
{

    public int numCaught;

    public int combo; //checking how many u caught in succession!

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //getting where your mouse is in the actual game
        Vector2 mousePos2D = new Vector2(mousePos.x, transform.position.y); // turning that vector 3 into a vector 2 for raycasting sake
        //THE TWIST IS THE Y CAN'T GO UP OR DOWN!! which is why i did ^^

        transform.position = mousePos2D;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        combo += 1;
        numCaught += 1;
        gameController.instance.applesCaught = numCaught;
        Destroy(collision.gameObject); // bye bye apple!
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mouseContoller : MonoBehaviour //CONTROLS MOUSE FOR WOOD GAME!
{
    public float timer;

    public int treesCut; // the number of trees cut down
    public GameObject currentTree_OBJ; // the current tree we're cutting down
    public treeScript currentTree_SCR; // the current tree's script

    treeManager tM;

    public float dist2Tree; // the distance between the tree and the mouse
    public float maxDist2Tree; //what dist do u need to be to cut the tree properly?

    public Vector3 leftPos; //a position on the left of the tree
    public Vector3 rightPos; // a position on the right of the tree

    public Vector3 maxLeftPos; // the position stored BEFORE moving right
    public Vector3 maxRightPos;  // the position stored BEFORE moving left

    // Start is called before the first frame update
    void Start()
    {
        tM = FindObjectOfType<treeManager>(); // we need this to access that handy dandy list!
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //getting where your mouse is in the actual game
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y); // turning that vector 3 into a vector 2 for raycasting sake
        Vector3 currentTreePos = tM.treeObjects[treesCut].transform.position;

        transform.position = mousePos2D; // its 2d instead of vector3 to keep the trailRenderer in front of the camera

        if (tM.treeScripts.Count > treesCut)
        {

            if (tM.treeScripts[treesCut] != null)
            {
                tM.treeScripts[treesCut].isCurrentTree = true;
            }

            //dist2Tree = Vector2.Distance(mousePos2D, tM.treeObjects[treesCut].transform.position);
            // above was a test

            //here begins the distance

            if (maxLeftPos == Vector3.zero)
            {
                if (mousePos2D.x < currentTreePos.x) //if you're to the LEFT of the tree
                {
                    leftPos = transform.position; // lets get that left position!
                }

                //if we're starting to move to the right because out x is shrinking!
                if (transform.position.x < leftPos.x)
                {
                    maxLeftPos = transform.position;
                }
            }
            if (maxRightPos == Vector3.zero)
            {
                if (mousePos2D.x > currentTreePos.x) //if you're to the RIGHT of the tree
                {
                    rightPos = transform.position; // lets get that right position!
                }

                //if we're starting to move to the right because out x is growing!
                if (transform.position.x > rightPos.x)
                {
                    maxRightPos = transform.position;
                }
            }

            if (maxLeftPos != Vector3.zero && Vector3.Distance(maxLeftPos,currentTreePos) >= maxDist2Tree)
            {
                Debug.Log("heyhey");
                tM.treeScripts[treesCut].treeHP -= 1;
            }
            else
            {
                Debug.Log("no cut for u!");
            }

            //here ends the distance





            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero); //storing what we may have hit via raycasting!

            if (hit.collider != null)
            {
                //if (hit.collider.gameObject == tM.treeObjects[treesCut]) ye old way!
                //{
                //    Debug.Log("heyhey");
                //    tM.treeScripts[treesCut].treeHP -= 1;
                //}
            }
        }
    }
}

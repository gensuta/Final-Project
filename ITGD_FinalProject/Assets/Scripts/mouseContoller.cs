using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mouseContoller : MonoBehaviour
{
    public float timer;

    public int treesCut; // the number of trees cut down
    public GameObject currentTree_OBJ; // the current tree we're cutting down
    public treeScript currentTree_SCR; // the current tree's script

    treeManager tM;

    // Start is called before the first frame update
    void Start()
    {
        tM = FindObjectOfType<treeManager>(); // we need this to access that handy dandy list!
    }

    // Update is called once per frame
    void Update()
    {
        if (tM.treeScripts.Count > treesCut)
        {

            if (tM.treeScripts[treesCut] != null)
            {
                tM.treeScripts[treesCut].isCurrentTree = true;
            }


            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //getting where your mouse is in the actual game
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y); // turning that vector 3 into a vector 2 for raycasting sake

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero); //storing what we may have hit via raycasting!

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == tM.treeObjects[treesCut])
                {
                    tM.treeScripts[treesCut].treeHP -= 1;
                }

                //treesCut += 1;
                //Debug.Log(hit.collider.gameObject.name + " " + treesCut.ToString());
            }
        }
    }
}

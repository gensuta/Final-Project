using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScript : MonoBehaviour
{
    public int treeType; // if its a weak or strong tree. Or if we decide to add more tree types
                         // 0 is weak, 1 is strong

    public int treeNum; //where is this tree in the treeManager list? The first or the last tree?
    public bool isCurrentTree; // to test if our boxcollider is active!

    BoxCollider2D bc; // the tree's box collider
    SpriteRenderer sp; //the tree's sprite renderer

    public int treeHP; // how many times must I be slashed by the mouse? 

    public Animator anim;


    mouseContoller mC;

    public bool didAdd; // adds to treesCut only ONCE


    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        mC = FindObjectOfType<mouseContoller>();
        bc = GetComponent<BoxCollider2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.instance.timeLeft <= 0f)
        {
            anim.SetInteger("whichAnim", -1); // -1 means fade out and die
            Destroy(gameObject, 0.5f);
        }
        else
        {
            if (isCurrentTree) // you're the current tree!
            {
                anim.SetInteger("whichAnim", 0); // 0 means go to currentTree color
                bc.enabled = true;
            }

            else // you're NOT the current tree!
            {
                anim.SetInteger("whichAnim", 1); // 1 means go to NOTcurrentTree color
                bc.enabled = false;
            }

            if (treeHP <= 0) // you're dead
            {
                if (!didAdd)
                {
                    mC.treesCut += 1;
                    gameController.instance.woodCut = mC.treesCut;

                    Debug.Log("u got wood!");
                    anim.SetInteger("whichAnim", -1); // -1 means fade out and die
                    didAdd = true;
                    bc.enabled = false;
                    Destroy(gameObject, 1.5f);
                }

            }
        }
    }

    public void InitializeTree(int num, int type)
    {
        treeNum = num; // this is what order the tree is! bigger is farther back
        sp.sortingOrder = -num; // we make num negative so that the bigger nums are further back instead of further forward

        if (type == 0) // weak trees have 1 hp
        {
            treeHP = 1;
        }
        else if (type == 1) // strong trees have 2 hp
        {
            treeHP = 2;
        }
    }
}

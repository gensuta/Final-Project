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


    public Color currentTree_COL; // if you're the current tree yr clear!
    public Color notCurrent_COL; // if you're not the current tree you're slightly desaturated
    public Color deathColor; // if the tree is gone

    public float changeColor_SPD; // the speed at which the trees color changes

    mouseContoller mC;

    public bool didAdd; // adds to treesCut only ONCE

    // Start is called before the first frame update
    void Awake()
    {
        mC = FindObjectOfType<mouseContoller>();
        bc = GetComponent<BoxCollider2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCurrentTree)
        {
            bc.enabled = true;
        }

        else
        {
            bc.enabled = false;
        }

        if (treeHP <= 0)
        {
            if (!didAdd)
            {
                mC.treesCut += 1;
                Debug.Log("u got wood!");
                didAdd = true;
            }
            Destroy(gameObject,1f);
        }
    }

    private void FixedUpdate()
    {
        if (sp.color != deathColor && didAdd)
        {
            sp.color = Color.Lerp(deathColor, sp.color, changeColor_SPD);
        }
        if (sp.color != notCurrent_COL && !isCurrentTree)
        {
            sp.color = Color.Lerp(notCurrent_COL, sp.color, changeColor_SPD);
        }
        if (sp.color != currentTree_COL && isCurrentTree)
        {
            sp.color = Color.Lerp(currentTree_COL, sp.color, changeColor_SPD);
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

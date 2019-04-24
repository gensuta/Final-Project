using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeManager : MonoBehaviour
{

    public List<GameObject> treeObjects; //so that we can figure out which tree is the one we're cutting
    public List<treeScript> treeScripts; //so that we can figure out which script we're effecting

    public int totalTrees; //the total number of trees getting created
    public GameObject weak_treePrefab;
    public GameObject strong_treePrefab;

    // Start is called before the first frame update
    void Start()
    {
        treeScripts = new List<treeScript>();
        treeObjects = new List<GameObject>();
        CreateTrees(); // creating trees
        treeScripts[0].isCurrentTree = true; // setting the current tree to true
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateTrees()
    {
        for (int i = 0; i < totalTrees; i++)
        {
            GameObject thisTree; // getting our current tree we're making!
            int randomNum;

            if (i == 0)
            {
                 thisTree= Instantiate(weak_treePrefab, Vector3.zero, Quaternion.identity) as GameObject;
                 randomNum = 0;

            }
            else
            {
                randomNum = Random.Range(0, 2); // randomize if it's a weak or strong tree!

                if (randomNum == 0) // 0 means weak
                {
                    thisTree = Instantiate(weak_treePrefab, Vector3.zero, Quaternion.identity) as GameObject;
                }
                else // other nums are strong!
                {
                  thisTree = Instantiate(strong_treePrefab, Vector3.zero, Quaternion.identity) as GameObject;
                }
            }

            treeObjects.Add(thisTree); //adding new tree object to the list!
            if (thisTree.GetComponent<treeScript>() != null)
            {
                treeScript thisTree_SCR = thisTree.GetComponent<treeScript>();

                treeScripts.Add(thisTree_SCR); // adding tree script to list!
                thisTree_SCR.InitializeTree(i, randomNum);
            }
            else
            {
                Debug.Log("ERROR!");
            }
        }
    }
}

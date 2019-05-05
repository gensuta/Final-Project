﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public static gameController instance;
    public int woodCut;
    public int bricksDown;
    public int applesCaught;
    
    public int currentScene; // 0 start, 1 wood, 2 brick, 3 apples, 4 stats, 5 homeScene (final scene)
    public bool didKeep;

    public int rounds; 
    public int numGames; // how many games have you played so far? If you play 3 games the rounds go up by 1

    public int lastGame; // last game matches scene numbers. Detects what to show in stats

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!didKeep)
        {
            DontDestroyOnLoad(gameObject);
            didKeep = true;
        }

        //oooooh cheat cooooodes!
        if (Input.GetKey(KeyCode.LeftCommand))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                BackAScene();
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                ForwardAScene();
            }
            if (Input.GetKey(KeyCode.R))
            {
                ResetScene();
            }
        }
    }

    public int RandomScene()
    {
        int randomNum = Random.Range(1, 4);
        if (randomNum == lastGame)
        {
            randomNum = Random.Range(1, 4);
            if (randomNum == lastGame)
            {
                randomNum = 2;
            }
            else
            {
                return randomNum;
            }
        }
        else
        {
            return randomNum;
        }

        return 1;
    }


    public string GetSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }

    public void BackAScene() //when you wanna go back one scene
    {
        if (currentScene != 0)
        {
            currentScene -= 1;
            SceneManager.LoadScene(currentScene);
        }
    }
    public void ForwardAScene() //when you wanna go forward one scene
    {
        if (currentScene != SceneManager.sceneCountInBuildSettings - 1)
        {
            currentScene += 1;
            SceneManager.LoadScene(currentScene);
        }
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void PlaySFX(AudioClip clip, float vol = 0.6f) // makes playing sfx easier and less of a lengthy line!
    {
        AudioSource.PlayClipAtPoint(clip, Vector3.zero, vol);
    }
}
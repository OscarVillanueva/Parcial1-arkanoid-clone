using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;

    [SerializeField] private int numberOfLevels = 5;
    private int currentLevel = 1;
    
    private int leftBlocks;
    private string nextLevelName;

    public int PowerMultiplayer { set; get; }

    public int Points { set; get; }

    private void Awake()
    {
        if (!sharedInstance)
        {
            sharedInstance = this;
            PowerMultiplayer = 1;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void StartLevel(int currentBlocks, string nextLevel)
    {
        nextLevelName = nextLevel;
        leftBlocks = currentBlocks;
    }

    private void GoToNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
        currentLevel += 1;
    }

    public void AddPoints(int points)
    {
        Points += points;
        leftBlocks -= 1;

        if (leftBlocks <= 0 && currentLevel <= numberOfLevels)
        {
            GoToNextLevel();
        }
    }
}

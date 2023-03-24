using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;

    [SerializeField] private int numberOfLevels = 5;

    private int leftBlocks;
    private string nextLevelName;

    public int Points { set; get; }

    private void Awake()
    {
        if (!sharedInstance)
        {
            sharedInstance = this;
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
    }

    public void AddPoints(int points)
    {
        Points += points;
        leftBlocks -= 1;

        if (leftBlocks <= 0)
        {
            GoToNextLevel();
        }
    }
}

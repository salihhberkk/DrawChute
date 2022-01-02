using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoSingleton<LevelManager>
{

    [SerializeField] private bool isActive;
    [SerializeField] private List<Level> levels;

    private int levelIndex;
    private int levelIndicatorIndex = 1;

    //PlayerMovement player;

    private void Start()
    {
        //player = FindObjectOfType<PlayerMovement>();

        UIManager.Instance.ShowPanel(PanelType.Start);
        if (!isActive) return;
        levelIndex = PlayerPrefs.GetInt("LevelIndex", 0);
        levelIndicatorIndex = PlayerPrefs.GetInt("LevelIndicatorIndex", 1);
        if (levelIndex == levels.Count)
        {
            levelIndex = 0;
            PlayerPrefs.SetInt("LevelIndex", levelIndex);

        }

        Instantiate(levels[levelIndex].gameObject);
    }
    public int LevelIndicatorIndex
    {
        get => levelIndicatorIndex;
        set
        {
            levelIndicatorIndex = value;
            PlayerPrefs.SetInt("LevelIndicatorIndex", value);
        }
    }

    public int LevelIndex
    {
        get => levelIndex;
        set
        {
            levelIndicatorIndex = value;
            PlayerPrefs.SetInt("LevelIndex", value);
        }
    }
    internal void RestartLevel()
    {
        //player.DisableControl();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    internal void LoadNextLevel()
    {
        LevelIndicatorIndex++;
        LevelIndex++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

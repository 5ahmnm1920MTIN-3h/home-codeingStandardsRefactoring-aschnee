using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public const string mainScene = "MainScene";
    public const string menuScene = "MenuScene";
    public static GameManager instance;
    public GameObject gameOverPanel;
    public Text scoreText;
    string defaultText;
    int score = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach(TextureScroll item in scrollingObjects)
        {
            item.scroll = false;
            Debug.Log(item.name);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

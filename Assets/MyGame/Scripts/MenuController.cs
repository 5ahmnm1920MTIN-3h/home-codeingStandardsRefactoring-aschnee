using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{
    public const string mainScene = "MainScene";
    public void Play()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

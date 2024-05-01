using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
} // straight and forward for the buttons, start game starts it and quit quits

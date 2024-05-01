using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int sceneToLoad;

    public void MenuScreen()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Game Restarted");
    }
} //essentially the same as the main menu but takes care of pause and game over screens
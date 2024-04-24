using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public bool isPaused;

    private GameObject gameOverText;
    private GameObject restartButton;
    private GameObject menuButton;
    private GameObject pauseText;
    
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        restartButton = GameObject.Find("RestartButton");
        menuButton = GameObject.Find("MenuButton");
        pauseText = GameObject.Find("PauseText");
        pauseText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
            EndGame();
        else if (isPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            pauseText.gameObject.SetActive(false);
            restartButton.gameObject.SetActive(false);
            menuButton.gameObject.SetActive(false);
            isPaused = false;
            Time.timeScale = 1;
        }
        else if (!isGameOver && Input.GetKeyDown(KeyCode.Escape))
        {
            pauseText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            menuButton.gameObject.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}

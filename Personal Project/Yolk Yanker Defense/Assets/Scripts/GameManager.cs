using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public bool isPaused;

    private GameObject gameOverText;
    private GameObject restartButton;
    private GameObject menuButton;
    private GameObject pauseText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI eggText;

    public int score;
    public int eggs = 8;

    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1; // make sure the game starts and can move
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        restartButton = GameObject.Find("Restart Button");
        menuButton = GameObject.Find("Menu Button");
        pauseText = GameObject.Find("PauseText");
        pauseText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (eggs < 1) // if this condition is met the game is over
        {
            isGameOver = true;
            EndGame();
        }

        else if (isPaused && Input.GetKeyDown(KeyCode.Escape)) // this sets everything still and pulls up menu
        {
            pauseText.gameObject.SetActive(false);
            restartButton.gameObject.SetActive(false);
            menuButton.gameObject.SetActive(false);
            isPaused = false;
            Time.timeScale = 1;
        }
        else if (!isGameOver && Input.GetKeyDown(KeyCode.Escape)) // same thing but the message says game over
        {
            pauseText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            menuButton.gameObject.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            gameOverText.gameObject.SetActive(false); // if no conditions are met then by default gameover is inactive
        }
    }

    public void EndGame() // function that freezes everything and pulls up menu
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void UpdateGUI() // this is for other scripts to communicate and update score/eggs
    {
        scoreText.text = "Score: " + score;
        eggText.text = "Eggs: " + eggs;
    }
}

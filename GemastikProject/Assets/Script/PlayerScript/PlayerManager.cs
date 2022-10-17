using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;



    private void Awake()
    {

        isGameOver = false;
        Time.timeScale = 1;

    }

    void Update()
    {
        if (isGameOver)
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);

        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

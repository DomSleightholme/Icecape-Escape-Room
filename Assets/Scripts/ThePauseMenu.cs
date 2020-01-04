using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ThePauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject HudUI;
    public GameObject Options;

    void Update()
    {
        //Pause
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        HudUI.SetActive(true);
        Options.SetActive(false);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        HudUI.SetActive(false);
        Options.SetActive(false);
    }


    //Loads Main Menu

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void OpenURL()
    {
        //The Code below will open a web page to my developer twitter page when clicked on
        Application.OpenURL("https://twitter.com/dom_dorito");
        Debug.Log("Load Up Twitter Page");
    }
}
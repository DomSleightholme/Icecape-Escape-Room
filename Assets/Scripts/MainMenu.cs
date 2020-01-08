using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //Variable to control the Audio Mixer
    public AudioMixer audioMixer;

    //This method will run when the play selects Play button
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //This method will run when the Exit button is selected
    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    //This method will control the volume of the Game
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    //This controls if the game is in fullscreen or not in fullscreen
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

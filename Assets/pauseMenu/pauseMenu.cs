using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //buttons
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void LawScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    public void GetBack()
    {
        SceneManager.LoadScene(1);
    }
}

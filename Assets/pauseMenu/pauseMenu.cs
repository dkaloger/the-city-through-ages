using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    public GameObject MoveToMouseScript;

    public  bool GameIsPaused = false;

    public GameObject PauseMenu;

    private void Start()
    {
        MoveToMouseScript.GetComponent<movetomouse>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                pause();
            }
            else
            {
                resume();
            }
        }
    }
    void resume()
    {
        MoveToMouseScript.GetComponent<movetomouse>().unpauseGame();
        PauseMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }
    public void pause()
    {
        MoveToMouseScript.GetComponent<movetomouse>().pauseGame();
        PauseMenu.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0f;
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
        MoveToMouseScript.GetComponent<movetomouse>().unpauseGame();
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

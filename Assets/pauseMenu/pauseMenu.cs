using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
public bool muted;
public Sprite mute;
public Sprite unmute;
public GameObject mutebuton;
    public GameObject MoveToMouseScript;

    public GameObject PlayerControllerScript;

    public  bool GameIsPaused = false;

    public GameObject PauseMenu;

    private void Start()
    {
        MoveToMouseScript.GetComponent<movetomouse>();
        PlayerControllerScript.GetComponent<playercontroller>();
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
        PlayerControllerScript.GetComponent<playercontroller>().CanScroll();
        MoveToMouseScript.GetComponent<movetomouse>().unpauseGame();
        PauseMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }
    public void pause()
    {
        MoveToMouseScript.GetComponent<movetomouse>().pauseGame();
        PlayerControllerScript.GetComponent<playercontroller>().CantScroll();
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
        if(muted == true){
            mutebuton.GetComponent<SpriteRenderer>().sprite = mute;
            muted = false;
        }
        if (muted == false)
        {
            mutebuton.GetComponent<SpriteRenderer>().sprite = unmute;
            muted = true;
        }
       
        AudioListener.pause = !AudioListener.pause;
        //very smart
    }
    public void GetBack()
    {
        SceneManager.LoadScene(1);
    }
}

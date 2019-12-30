using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetomouse : MonoBehaviour
{
    [SerializeField] private Vector3 mousePosition;
    [SerializeField] private float moveSpeed = 0.1f;
    [SerializeField] private GameObject wheel;
    public pauseMenu pause;

    void Update()
    {
        moveToMouseFunc();
    }

    void moveToMouseFunc()
    {
        if (pause.GameIsPaused)
        {
            wheel.SetActive(false);
        }
        else
        {
            wheel.SetActive(true);
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = mousePosition;
        }
    }
}
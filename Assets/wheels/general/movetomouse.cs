using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetomouse : MonoBehaviour
{
    public Canvas myCanvas;

    public bool pause;


    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (pause == false)
        {
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
            rb.MovePosition(myCanvas.transform.TransformPoint(pos));
        }

    }

    public void pauseGame()
    {
        pause = true;
    }

    public void unpauseGame()
    {
        pause = false;
    }
}

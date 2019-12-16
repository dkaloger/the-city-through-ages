using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetomouse : MonoBehaviour
{
    public Canvas myCanvas;
    // Start is called before the first frame update


    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
        transform.position = myCanvas.transform.TransformPoint(pos);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public bool canScroll = true;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movevelocity;
public    Vector3 leftsidelimits;
    public Vector3 rightsidelimits;
    Vector2 roundedpos;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GetComponent<Camera>().orthographicSize < 5.735542)
        {
            speed = 0.5f;
        }
        if (GetComponent<Camera>().orthographicSize > 10)
        {
            speed = GetComponent<Camera>().orthographicSize / 20;
        }

        if (GetComponent<Camera>().orthographicSize == 10)
        {
            speed = GetComponent<Camera>().orthographicSize / 10;
        }
      
        if (GetComponent<Camera>().orthographicSize > 10)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0 && canScroll == true)
            {
                GetComponent<Camera>().orthographicSize -= 10;
            }
        }
        if (GetComponent<Camera>().orthographicSize < 50 && GetComponent<Camera>().orthographicSize>2f)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0 && canScroll == true)
            {
                GetComponent<Camera>().orthographicSize += 10;
            }
        }
   
       
        
      
     
    }

    private void FixedUpdate()
    {
        Vector2 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));


        movevelocity = moveinput.normalized * speed;
           
            rb.MovePosition( rb.position + movevelocity);
        
 
           
        
        
    }

    public void CantScroll()
    {
        canScroll = false;
    }
    public void CanScroll()
    {
        canScroll = true;
    }
}
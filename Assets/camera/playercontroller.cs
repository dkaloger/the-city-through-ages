using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

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
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                GetComponent<Camera>().orthographicSize -= 10;
            }
        }
        if (GetComponent<Camera>().orthographicSize < 50 && GetComponent<Camera>().orthographicSize>2f)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                GetComponent<Camera>().orthographicSize += 10;
            }
        }
   
       
        Vector2 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movevelocity = moveinput.normalized * speed;
    }

    private void FixedUpdate()
    {
  

      
            roundedpos.x = (Mathf.Round(rb.position.x));
            roundedpos.y = (Mathf.Round(rb.position.y));
        rb.MovePosition(roundedpos + movevelocity);
           
        
        
    }
}
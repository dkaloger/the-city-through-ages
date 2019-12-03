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
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speed =   GetComponent<Camera>().orthographicSize;
        if (GetComponent<Camera>().orthographicSize > 3.735543)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                GetComponent<Camera>().orthographicSize -= 5;
            }
        }
        if (GetComponent<Camera>().orthographicSize < 50)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                GetComponent<Camera>().orthographicSize += 5;
            }
        }
        Vector2 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movevelocity = moveinput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movevelocity * Time.fixedDeltaTime);
    }
}
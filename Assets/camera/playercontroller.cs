using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [Header("Velocities")]
    public float speed;
    public float speedWhenSlowedDown; //The speed when cameraOrthoSize is < cameraOrthoSizeMinLimit;
    public float cameraOrthoIncrement; //The incrementation for how much the orthographic will change when the scrollWheel assigned;
    public float cameraOrthoIncrementSlowed;

    private float currentSpeed; //This is the one that will be modified on the code;

    [Space]
    [Header("Camera Zoom Limit")]
    public float cameraOrthoSizeMaxLimit; //Limitation for the camera zoom, so it can be changed in the future;
    public float cameraOrthoSizeMinLimit; //Making it not harcoded as well;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    [Space]
    [Header("Camera Bounds")]
    public Vector3 leftsidelimits; // --(!!!)-- CameraBounding still unessesary --(!!!)--;
    public Vector3 rightsidelimits; // --(!!!)-- CameraBounding still unessesary --(!!!)--;

    Vector2 roundedpos; // --(!!!)-- (Vector2)roundedpos still unessesary --(!!!)--;

    [Space]
    public float cameraOrthoSize;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraOrthoSize = GetComponent<Camera>().orthographicSize = cameraOrthoSizeMinLimit;
    }

    private void FixedUpdate()
    {
        CameraMovement();
        CameraScale();      
    }

    void CameraMovement()
    {
        Vector2 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveVelocity = moveinput.normalized * (currentSpeed * Time.fixedDeltaTime);

        rb.velocity = new Vector2(moveVelocity.x, moveVelocity.y);
    }

    void CameraScale()
    {
        if (cameraOrthoSize <= cameraOrthoSizeMinLimit) //Previous is 5.735542f; (In case you want to change this);
        {
            currentSpeed = speedWhenSlowedDown;
        }

        if (cameraOrthoSize >= cameraOrthoSizeMinLimit)
        {
            currentSpeed = speed;
        }

        //Camera Input Scale;
        if (cameraOrthoSize <= cameraOrthoSizeMaxLimit)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                cameraOrthoSize += cameraOrthoIncrement;
                GetComponent<Camera>().orthographicSize = cameraOrthoSize;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                cameraOrthoSize -= cameraOrthoIncrement;
                GetComponent<Camera>().orthographicSize = cameraOrthoSize;
            }       
        }
        else if (cameraOrthoSize < cameraOrthoSizeMinLimit)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                
                cameraOrthoSize += cameraOrthoIncrementSlowed;
                GetComponent<Camera>().orthographicSize = cameraOrthoSize;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0 && cameraOrthoSize != 0)
            {
                if (cameraOrthoSize == 0)
                {
                    cameraOrthoSize = 1;
                }

                cameraOrthoSize -= cameraOrthoIncrementSlowed;
                GetComponent<Camera>().orthographicSize = cameraOrthoSize;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSaving : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            saving.savePosOfCam(this);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            posSave data = saving.loadPos();

            Vector3 position;
            position.x = data.posOfCam[0];
            position.y = data.posOfCam[1];
            position.z = data.posOfCam[2];

            transform.position = position;
        }
    }
}

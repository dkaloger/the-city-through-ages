using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSaving : MonoBehaviour
{

    public List<float> buildingsPosX = new List<float>();
    public List<float> buildingsPosY = new List<float>();
    public List<string> buildingsName = new List<string>();

    void Start()
    {
        
    }

    void Update()
    {

        //in game content
        if (Input.GetKeyDown(KeyCode.O))
        {
            savingBuildPos buildingData = saving.loadPosOfBuilding();

            //put the text file into the game
            for (int i = 0; i < buildingData.posOfBuildingX.Length; i++)
            {
                buildingsPosX[i] = buildingData.posOfBuildingX[i];
                buildingsPosY[i] = buildingData.posOfBuildingY[i];
                buildingsName[i] = buildingData.buildingsNames[i];
            }
        }
        //gives the system the data
        else if (Input.GetKeyDown(KeyCode.P))
        {
            saving.savePosOfBuilding(this);
        }
        //test content just to see if ot worked
        if (Input.GetKeyDown(KeyCode.V))
        {
            saving.savePosOfCam(this);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            posSave data = saving.loadPosOfCam();

            Vector3 position;
            position.x = data.posOfCam[0];
            position.y = data.posOfCam[1];
            position.z = data.posOfCam[2];

            transform.position = position;
        }
    }
}

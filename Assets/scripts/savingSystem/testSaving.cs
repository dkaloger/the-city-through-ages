using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSaving : MonoBehaviour
{
    public placebuildings placeBuildings;
    public List<float> buildingsPosX = new List<float>();
    public List<float> buildingsPosY = new List<float>();
    public List<string> buildingsName = new List<string>();


    void Update()
    {

        //in game content
        if (Input.GetKeyDown(KeyCode.L))
        {
            savingBuildPos buildingData = saving.loadPosOfBuilding();

            Debug.Log(buildingData.posOfBuildingX.Length);

            //put the text file into the game
            for (int i = 0; i < buildingData.buildingsNames.Length; i++)
            {
                Debug.Log(buildingsPosX.Count);
                buildingsPosX.Add(buildingData.posOfBuildingX[i]);
                buildingsPosY.Add(buildingData.posOfBuildingY[i]);
                buildingsName.Add(buildingData.buildingsNames[i]);
                placeBuildings.makeBuilding(buildingsPosX[i], buildingsPosY[i], buildingsName[i]);
            }
        }
        //gives the system the data
        else if (Input.GetKeyDown(KeyCode.P))
        {
            /*
            for (int i = 0; i > placeBuildings.buildingsPosX.Count; i++)
            {
                buildingsPosX.Add(placeBuildings.buildingsPosX[i]);
                buildingsPosY.Add(placeBuildings.buildingsPosY[i]);
                buildingsName.Add(placeBuildings.Names[i]);
            }
            */

            //calls the function there creates the list for one sec
            placeBuildings.takeOutThePos();

            //taking the list from placebuildings 
            buildingsPosX = placeBuildings.buildingsPosX;
            buildingsPosY = placeBuildings.buildingsPosY;
            buildingsName = placeBuildings.Names;
            //gives saving this so that will mean that the saving scripts gets the arrays
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

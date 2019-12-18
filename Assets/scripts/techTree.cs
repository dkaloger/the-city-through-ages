
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class techTree : MonoBehaviour
{

    public buildWheelOptions BuildWheelOptions;

    public int [] buildings;

    private int tier = 0;


    void Update()
    {

        if (buildings[0] >= 1)
        {
            tier++;

            BuildWheelOptions.addTier(tier);

            buildings[0] = 0;
            buildings[5] = 0;
        }
        //Debug.Log(buildings[0] + "this is building 0");
        //Debug.Log(buildings[5] + "this is building 5");
    }

    public void addBuilding(int buildingNum)
    {
        buildings[buildingNum]++;
        Debug.Log(buildingNum+1 + " buildingNum");
        
    }

}
///
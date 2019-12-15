using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class techTree : MonoBehaviour
{

    public int [] buildings;

    private int tier = 0;
    [SerializeField] TMPro.TextMeshProUGUI textMeshProUGUI;


    void Update()
    {

        if (buildings[0] >= 2 && buildings[5] >= 1 && tier == 0)
        {
            tier++;
            textMeshProUGUI.text = "your tier is: " + tier;
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
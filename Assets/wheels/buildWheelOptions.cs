using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class buildWheelOptions : MonoBehaviour
{

    private int curTier = 1;
    int[] buildingsAllowed = new int[1];

    [SerializeField] Sprite[] mySprites = new Sprite[8];

    [SerializeField] GameObject[] myBuildings = new GameObject[8];

    public bool orderwheelon;
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Array.Exists(buildingsAllowed, element => element == curTier -1))
            {
                curTier = buildingsAllowed[curTier - 1];
                changeImage(curTier);
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (Array.Exists(buildingsAllowed, element => element == curTier + 1))
            {
                curTier = buildingsAllowed[curTier + 1];
                changeImage(curTier);
            }
        }
        if (Input.GetKeyDown(KeyCode.O))  {
            myBuildings[0].GetComponent<SpriteRenderer>().sprite = mySprites[16];
            myBuildings[1].GetComponent<SpriteRenderer>().sprite = mySprites[17];
            myBuildings[2].GetComponent<SpriteRenderer>().sprite = mySprites[18];
            myBuildings[3].GetComponent<SpriteRenderer>().sprite = mySprites[19];
            myBuildings[4].GetComponent<SpriteRenderer>().sprite = mySprites[20];
            myBuildings[5].GetComponent<SpriteRenderer>().sprite = mySprites[21];
            myBuildings[6].GetComponent<SpriteRenderer>().sprite = mySprites[22];
            myBuildings[7].GetComponent<SpriteRenderer>().sprite = mySprites[23];
        }
    }

    public void changeImage(int tier)
    {
        if (tier == 0)
        {
            myBuildings[0].GetComponent<SpriteRenderer>().sprite = mySprites[0];
            myBuildings[1].GetComponent<SpriteRenderer>().sprite = mySprites[1];
            myBuildings[2].GetComponent<SpriteRenderer>().sprite = mySprites[2];
            myBuildings[3].GetComponent<SpriteRenderer>().sprite = mySprites[3];
            myBuildings[4].GetComponent<SpriteRenderer>().sprite = mySprites[4];
            myBuildings[5].GetComponent<SpriteRenderer>().sprite = mySprites[5];
            myBuildings[6].GetComponent<SpriteRenderer>().sprite = mySprites[6];
            myBuildings[7].GetComponent<SpriteRenderer>().sprite = mySprites[7];
        }
        if (tier == 1)
        {
            myBuildings[0].GetComponent<SpriteRenderer>().sprite = mySprites[8];
            myBuildings[1].GetComponent<SpriteRenderer>().sprite = mySprites[9];
            myBuildings[2].GetComponent<SpriteRenderer>().sprite = mySprites[10];
            myBuildings[3].GetComponent<SpriteRenderer>().sprite = mySprites[11];
            myBuildings[4].GetComponent<SpriteRenderer>().sprite = mySprites[12];
            myBuildings[5].GetComponent<SpriteRenderer>().sprite = mySprites[13];
            myBuildings[6].GetComponent<SpriteRenderer>().sprite = mySprites[14];
            myBuildings[7].GetComponent<SpriteRenderer>().sprite = mySprites[15];
        }

    }

  
    void test()
    {
        changeImage(0);
    }

}

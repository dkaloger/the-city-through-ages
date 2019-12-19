using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildWheelOptions : MonoBehaviour
{

    private int curTier = 0;

    public List<int> tiersUnlocked = new List<int>();


    [SerializeField] Sprite[] mySprites = new Sprite[8];

    [SerializeField] GameObject[] myBuildings = new GameObject[8];

    public bool orderWheelOn;
    private void Start()
    {
        tiersUnlocked.Add(0);
        tiersUnlocked.Add(1);
        myBuildings[0].GetComponent<SpriteRenderer>().sprite = mySprites[0];
        myBuildings[1].GetComponent<SpriteRenderer>().sprite = mySprites[1];
        myBuildings[2].GetComponent<SpriteRenderer>().sprite = mySprites[2];
        myBuildings[3].GetComponent<SpriteRenderer>().sprite = mySprites[3];
        myBuildings[4].GetComponent<SpriteRenderer>().sprite = mySprites[4];
        myBuildings[5].GetComponent<SpriteRenderer>().sprite = mySprites[5];
        myBuildings[6].GetComponent<SpriteRenderer>().sprite = mySprites[6];
        myBuildings[7].GetComponent<SpriteRenderer>().sprite = mySprites[7];
    }

    void Update()
    {

        Debug.Log(curTier);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (curTier != 0 && orderWheelOn == false)
            {
                curTier = tiersUnlocked[curTier - 1];
                changeImage(curTier);
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (curTier != tiersUnlocked.Count -1 && orderWheelOn == false)
            {
                curTier = tiersUnlocked[curTier +1];
                changeImage(curTier);
            }

        }
        if (Input.GetKeyDown(KeyCode.O))  {
            if (orderWheelOn == true)
            {
                changeImage(curTier);
                orderWheelOn = false;
            }
            else
            {
                orderWheelOn = true;
                myBuildings[1].GetComponent<SpriteRenderer>().sprite = mySprites[16];
                myBuildings[2].GetComponent<SpriteRenderer>().sprite = mySprites[17];
                myBuildings[3].GetComponent<SpriteRenderer>().sprite = mySprites[18];
                myBuildings[4].GetComponent<SpriteRenderer>().sprite = mySprites[19];
                myBuildings[5].GetComponent<SpriteRenderer>().sprite = mySprites[20];
                myBuildings[6].GetComponent<SpriteRenderer>().sprite = mySprites[21];
                myBuildings[7].GetComponent<SpriteRenderer>().sprite = mySprites[22];
            }
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
            myBuildings[1].GetComponent<SpriteRenderer>().sprite = mySprites[9];
            myBuildings[2].GetComponent<SpriteRenderer>().sprite = mySprites[10];
            myBuildings[3].GetComponent<SpriteRenderer>().sprite = mySprites[11];
            myBuildings[4].GetComponent<SpriteRenderer>().sprite = mySprites[12];
            myBuildings[5].GetComponent<SpriteRenderer>().sprite = mySprites[13];
            myBuildings[6].GetComponent<SpriteRenderer>().sprite = mySprites[14];
            myBuildings[7].GetComponent<SpriteRenderer>().sprite = mySprites[15];
        }

    }


  
    

    public void addTier(int tier)
    {
        //buildingsAllowed = new int [0];
    }

}

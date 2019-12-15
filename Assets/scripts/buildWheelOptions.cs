using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildWheelOptions : MonoBehaviour
{

    [SerializeField] Sprite[] mySprites = new Sprite[8];

    [SerializeField] GameObject[] myBuildings = new GameObject[8];

    private void Start()
    {
        Invoke("test", 2);
    }

    void Update()
    {
        
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
    }

    void test()
    {
        changeImage(0);
    }

}

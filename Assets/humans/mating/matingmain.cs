using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matingmain : MonoBehaviour
{
    [SerializeField]
    fooddipslay foodD;
    [SerializeField]
    popdisp popdispv;
    int popdelay;

    [SerializeField]
    public  int standartgrowthspeed;
    [SerializeField]
    public  int popfoodcostonce;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void fixedupdate()
    {
        popdelay += PlayerPrefs.GetInt("matingspeed");
    }
    // Update is called once per frame
    void Update()
    {
        
        
       
        if (popdelay>standartgrowthspeed )
        {
            popdelay = 0;
            popdispv.pop++;
            foodD.food -= popfoodcostonce;
        }
    }
}

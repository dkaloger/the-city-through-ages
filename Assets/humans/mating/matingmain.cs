using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matingmain : MonoBehaviour
{
    [SerializeField]
    fooddipslay foodD;
    [SerializeField]
    popdisp popdispv;
  public  int popdelay;

    [SerializeField]
    public  int standartgrowthspeed;
    [SerializeField]
    public  int popfoodcostonce;
    // Start is called before the first frame update
   
    void FixedUpdate()
    {
        Debug.Log("l21m");
        popdelay += PlayerPrefs.GetInt("matingspeed");
    }
    // Update is called once per frame
    void Update()
    {

        Debug.Log("l28m");
       
        if (popdelay>standartgrowthspeed )
        {
            popdelay = 0;
            popdispv.pop++;
            foodD.food -= popfoodcostonce;
        }
    }
}

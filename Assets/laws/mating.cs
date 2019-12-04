using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mating : MonoBehaviour
{

    public int matingspeedint;
    // Start is called before the first frame update

    public void matingspeed(float newmatingspeed) 
    {
        matingspeedint = (int)newmatingspeed;
        PlayerPrefs.SetInt("matingspeed", matingspeedint);
    }

}
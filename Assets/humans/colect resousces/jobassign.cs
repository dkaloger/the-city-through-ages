using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jobassign : MonoBehaviour
{
    popdisp pop;
   public int miningjobs;
    public int lumberjobs;
    Slider s1;
   
    // Start is called before the first frame update
    void Start()
    {
        
        miningjobs = Mathf.RoundToInt(s1.value / pop.pop);
        lumberjobs = Mathf.RoundToInt((100f - s1.value) / pop.pop);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

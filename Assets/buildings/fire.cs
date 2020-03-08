using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
 public   fooddipslay fd;
  public  int t ;
 public   int fooddelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if  (fd.unfood > 0)
        {

            t++;
            if(t > fooddelay)
            {
                fd.food += 2;
                fd.unfood -= 1;
                t = 0;
            }
        }  
    }
}

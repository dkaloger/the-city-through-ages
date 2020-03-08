using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paasivefoodcost : MonoBehaviour
{
    [SerializeField]
     int t;
    public fooddipslay fd;
    public int popcost;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    t ++ ;
    if (t > 1000){
            fd.food -= popcost * PlayerPrefs.GetInt("pop");
         
            t = 0;
        }
       
    }
}

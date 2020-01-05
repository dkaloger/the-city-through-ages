using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectr : MonoBehaviour
{
    int myjob;
    float speed;
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
if (myjob ==1 ){
            target = GameObject.FindGameObjectWithTag("chop");
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position,speed);
}
   
    }
}

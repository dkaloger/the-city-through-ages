using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collectr : MonoBehaviour
{
[SerializeField]
    int myjob;
    // 1 lumber
    // 2 mining

    float speed;
    GameObject target;
[SerializeField]
    jobassign jobassin;

    // Start is called before the first frame update
    void Start()
    {
        jobassin.lumberjobs = PlayerPrefs.GetInt("lumb");
        jobassin.miningjobs = PlayerPrefs.GetInt("mine");
        if (jobassin.lumberjobs > 0)
        {
            myjob = 2;
            jobassin.lumberjobs -= 1;
            PlayerPrefs.SetInt("lumb", PlayerPrefs.GetInt("lumb") - 1);
        }
        else if (jobassin.miningjobs > 0)
        {
            myjob = 2;
            PlayerPrefs.SetInt("mine", PlayerPrefs.GetInt("mine") - 1);
        }

     
      
    }

    // Update is called once per frame
    void Update()
    {
    
        if (myjob == 1)
        {
            target = GameObject.FindGameObjectWithTag("chop");
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);


        }

}
   
    }


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
     
        

     
      
    }

    // Update is called once per frame
    void Update()
    {
        if (jobassin.relativelumberjobs > 0 && myjob == 0)
        {
            myjob = 1;
            jobassin.relativelumberjobs -= 1;
            PlayerPrefs.SetInt("chop", PlayerPrefs.GetInt("chop") - 1);
        }
        else if (jobassin.relativeminingjobs > 0&& myjob == 0)
        {
            myjob = 2;
            jobassin.relativeminingjobs -= 1;
            PlayerPrefs.SetInt("mine", PlayerPrefs.GetInt("mine") - 1);
        }
        if (myjob == 1)
        {
            target = GameObject.FindGameObjectWithTag("chop");
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);


        }

}
   
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingbasescript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform parent;
    [SerializeField]
        private bool doneonce = false;

    // Update is called once per frame


    void Update()
    {
        transform.SetParent(parent, false);
if(doneonce == false ){
           
            transform.position = new Vector3(0, 0, 1);
            doneonce = true;
        }
       
    }
}

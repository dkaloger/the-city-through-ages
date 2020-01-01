using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placebuildings : MonoBehaviour
{
    [SerializeField]
GameObject testbuilding;
[SerializeField]
FX_Player gf;
[SerializeField]

Vector3 pos;
[SerializeField] Quaternion idk;
[SerializeField]


Transform mapt;
[SerializeField]
Vector3 maposset;
[SerializeField]
FX_MapGen mpp;
    // Start is called before the first frame update
    void Start()
    {
        mapt = mpp.Map;
        mapt.position = maposset;
        mapt.Rotate(-90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
      
        if(Input.GetKeyDown(KeyCode.Mouse0)){
           
            pos = new Vector3(gf.TargetHex.position.x, gf.TargetHex.position.y , gf.TargetHex.position.z- 2f);
        
       
          
            Instantiate(testbuilding,pos,idk );
        }
    }
}

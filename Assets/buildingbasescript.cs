using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingbasescript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform parent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, 1);
    }
}

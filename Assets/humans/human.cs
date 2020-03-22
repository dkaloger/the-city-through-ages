using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human : MonoBehaviour
{
    fooddipslay fd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fd.food < 0)
        {
            Destroy(gameObject);
            fd.food += 100;
        }
    }
}

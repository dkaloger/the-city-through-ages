using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using TMPro;
public class jobsystem : MonoBehaviour
{
    [SerializeField]
    Image wedg1;
    [SerializeField]
    Image wedg2;
   
   
    public Slider s12;

    public Slider s22;
    void Update() {
    
        wedg1.fillAmount = s12.value;
        wedg2.fillAmount = s22.value;
    }

     public void s1changed(){
        s22.value = 1 - s12.value;
    }
    public void s2changed()
    {
        s12.value = 1 - s22.value;
    }
}

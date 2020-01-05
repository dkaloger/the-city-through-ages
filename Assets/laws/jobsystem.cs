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
    [SerializeField]
    Slider s1;
    [SerializeField]
    Slider s2;
    void Update() {
        
        wedg1.fillAmount = s1.value;
        wedg2.fillAmount = s2.value;
    }

     public void s1changed(){
        s2.value = 1 - s1.value;
    }
    public void s2changed()
    {
        s1.value = 1 - s2.value;
    }
}

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
   
   
    public Slider choptrees;

    public Slider mines;
    public int minei;
    public int choptreei;
    
    void Update() {
    minei = Mathf.RoundToInt(mines.value);
        wedg1.fillAmount = choptrees.value;
        wedg2.fillAmount = mines.value;
        PlayerPrefs.SetInt("mine",minei);
           PlayerPrefs.SetInt("chop",choptreei);
           
    }

     public void s1changed(){
        mines.value = 100 - choptrees.value;
    }
    public void s2changed()
    {
        choptrees.value = 100 - mines.value;
    }
}

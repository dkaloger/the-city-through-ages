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
    //for a weird   reason they are inverted it doesnt cause problems but be careful
    public Slider mines;
    public int choptreei;
    public int minei;
    
    void Update() {
    minei = Mathf.RoundToInt(mines.value);
        choptreei = Mathf.RoundToInt(choptrees.value);
        PlayerPrefs.SetInt("mine",minei);
           PlayerPrefs.SetInt("chop",choptreei);
        wedg1.fillAmount = choptrees.value / 100f;
        wedg2.fillAmount = mines.value / 100f;
        choptrees.value = 100 - mines.value;
        mines.value = 100 - choptrees.value;
       
    }

   
}

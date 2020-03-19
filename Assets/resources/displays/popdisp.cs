using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class popdisp : MonoBehaviour
{
    int t;
    public int pop;
   public int maxpop = 10;
    public TextMeshProUGUI textMesH;
    public TextMeshProUGUI textMesH1;
    public GameObject spop;
    // Start is called before the first frame update
    void Start()
    {

        pop = PlayerPrefs.GetInt("pop");


    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = pop.ToString();
        textMesH1.text = maxpop.ToString();
        t++;
        if (t > 1000)
        {
            PlayerPrefs.SetInt("pop", pop);
            t = 0;
        }
    }
    void OnMouseOver()
    {
        spop.SetActive(true);
    }
    void OnMouseExit()
    {
        spop.SetActive(false);
    }
}

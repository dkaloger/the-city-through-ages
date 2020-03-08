using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class popdisp : MonoBehaviour
{
    public int pop;
   public int maxpop = 10;
    public TextMeshProUGUI textMesH;
    public TextMeshProUGUI textMesH1;
    public GameObject spop;
    // Start is called before the first frame update
    void Start()
    {
      
        pop = 2;
     

    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = pop.ToString();
        textMesH1.text = maxpop.ToString();
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

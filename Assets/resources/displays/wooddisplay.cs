using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class wooddisplay : MonoBehaviour
{
    public int wood;
    private TextMeshProUGUI textMesH;

    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
       
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = wood.ToString();      
    }
}

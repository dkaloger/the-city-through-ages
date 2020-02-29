using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class irondisplay : MonoBehaviour

{ 
    public int iron;
    private TextMeshProUGUI textMesH;

    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
        iron = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = iron.ToString();

    }
}

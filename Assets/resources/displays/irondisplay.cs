using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class irondisplay : MonoBehaviour

{ 
    public int iron;
    public int unrefinediron;
    private TextMeshProUGUI textMesH;
    public TextMeshProUGUI textMesH1;
    public GameObject siron;

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
        textMesH1.text = unrefinediron.ToString();
    }
    void OnMouseOver()
    {
        siron.SetActive(true);
    }
    void OnMouseExit()
    {
        siron.SetActive(false);
    }
}

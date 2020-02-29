using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class stonedisplay : MonoBehaviour
{

    public int stone;
    private TextMeshProUGUI textMesH;

    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
        stone = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = stone.ToString();

    }



}


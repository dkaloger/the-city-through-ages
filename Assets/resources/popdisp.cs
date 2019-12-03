using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class popdisp : MonoBehaviour
{
    public int pop;
    private TextMeshProUGUI textMesH;

    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
        pop = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = pop.ToString();

    }
}

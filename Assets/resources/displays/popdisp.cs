using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class popdisp : MonoBehaviour
{
    public int pop;
    int maxpop = 10;
    private TextMeshProUGUI textMesH;
    public TextMeshProUGUI textMesH1;
    public GameObject spop;
    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
        pop = 2;
        textMesH1.text = maxpop.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = pop.ToString();
        PlayerPrefs.SetInt("pop", pop);
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

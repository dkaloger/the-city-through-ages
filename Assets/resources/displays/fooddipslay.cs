using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class fooddipslay : MonoBehaviour
{
    public int food;
    public int unfood;
    private TextMeshProUGUI textMesH;

    public TextMeshProUGUI textMesH1;
   
    public GameObject sfood;
    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI>();
        food = 500;
       
        PlayerPrefs.SetInt("food", food);
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = food.ToString();
        textMesH1.text = unfood.ToString();
        PlayerPrefs.SetInt("food",food);
    }
    void OnMouseOver()
    {
        sfood.SetActive(true);
    }
    void OnMouseExit()
    {
        sfood.SetActive(false);
    }
}
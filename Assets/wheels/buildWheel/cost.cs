using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class cost : MonoBehaviour
{
    [SerializeField]
    placebuildings placeb;
    [SerializeField]
    buildWheelOptions bwo;
    [SerializeField]
    SpriteRenderer slot1im;
    [SerializeField]
    SpriteRenderer slot2im;
    [SerializeField]
    int slot1int;
    [SerializeField]
    int slot2int;
    [SerializeField]
    TextMeshProUGUI slot1t;
    [SerializeField]
    TextMeshProUGUI slot2t;
    [SerializeField]
    GameObject fire;
    [SerializeField]
    GameObject tent;
    [SerializeField]
    SpriteRenderer stone;
    [SerializeField]
    SpriteRenderer wood;

    public bool canafford;
    [SerializeField]
    stonedisplay stony;
    [SerializeField]
    SpriteRenderer food;
    [SerializeField]
    wooddisplay woody;
    [SerializeField]
    GameObject costg;
    [SerializeField]
    fooddipslay foody;
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        slot1t.text = slot1int.ToString();
        slot2t.text = slot2int.ToString();
        if (bwo.orderWheelOn == true)
        {
            canafford = true;
            costg.SetActive(false);
        }
        if (bwo.orderWheelOn != true)
        {

            costg.SetActive(true);
        }

        if (placeb.testbuilding == fire)
        {

            slot1im.sprite = stone.sprite;
            slot1int = 1;
            slot2im.sprite = wood.sprite;
            slot2int = 10;
            slot1t.text = slot1int.ToString();
            slot2t.text = slot2int.ToString();
            if (stony.stone > slot1int && woody.wood > slot2int)
            {
                canafford = true;
            }
            if (stony.stone < slot1int || woody.wood < slot2int)
            {
                canafford = false;
            }
            if (placeb.justplaced == true)
            {
                stony.stone -= slot1int;
                woody.wood -= slot2int;
            }
        }
            Debug.Log("82");
            if (placeb.testbuilding == tent)
            {
            Debug.Log("90");
            slot1im.sprite = food.sprite;
            slot2im.sprite = wood.sprite;
            slot1int = 20;
              
                slot2int = 3;
            slot1t.text = slot1int.ToString();
            slot2t.text = slot2int.ToString();
            if (foody.food > slot1int && woody.wood > slot2int)
                {
                    canafford = true;
                }
                if (foody.food < slot1int || woody.wood < slot2int)
                {
                    canafford = false;
                }
                if (placeb.justplaced == true)
                {
                    foody.food -= slot1int;
                woody.wood -= slot2int;
            }

            }
        
    }
}

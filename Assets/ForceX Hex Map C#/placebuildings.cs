using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using  UnityEngine.Tilemaps;
public class placebuildings : MonoBehaviour
{


    public Transform[] childTrans;
    public GameObject parrentObj;
    public List<float> buildingsPosX = new List<float>();
    public List<float> buildingsPosY = new List<float>();
    public List<string> Names = new List<string>();
    [SerializeField]
GameObject testbuilding;
[SerializeField]
FX_Player gf;
[SerializeField]

Vector3 pos;
[SerializeField] Quaternion idk;
[SerializeField]


Transform mapt;
[SerializeField]
Vector3 maposset;
[SerializeField]
FX_MapGen mpp;
[SerializeField]
Vector3[] tpos;
[SerializeField]
int curentcell;
[SerializeField]
Tilemap tilemap;
[SerializeField]
Vector3Int posi;
[SerializeField]
Tile df;
[SerializeField]
Sprite water;
    [SerializeField]
Sprite choptree;
[SerializeField]
    public Grid grid;
    [SerializeField]
    Tilemap myTileMap;
    [SerializeField]

    GameObject[] buildings;
    [SerializeField]

    glowmaster ri;
    [SerializeField]
    
    buildWheelOptions ti;
   
    public Sprite forest;
    public Sprite rockeyterrain;


    // Start is called before the first frame update
    void Start()
    {
        mapt = mpp.Map;
        mapt.position = maposset;
        mapt.Rotate(-90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        //child trans takes  the transforms of the buildings every frame
        childTrans = parrentObj.GetComponentsInChildren<Transform>();

        if (ti.orderWheelOn == false)
        {
            testbuilding = buildings[ti.curTier * 8 + ri.selectedring];
            Debug.Log(ti.curTier * 8 + ri.selectedring);
        }
        if (ti.orderWheelOn == true)
        {
            testbuilding = buildings[16 + ri.selectedring];
            Debug.Log(16 + ri.selectedring);
        }

        pos = new Vector3(gf.TargetHex.position.x, gf.TargetHex.position.y, gf.TargetHex.position.z - 2f);
        posi.x = (int)pos.x;
        posi.y = (int)pos.y;
        posi.z = 45;

        //Get position of the mouseclick
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Convert position of the mouseclick to the position of the tile located at the mouseclick
        Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
        //Display tile position in log

            //Display the sprite value of the tile in log *SUCCESS*

      
      if (Input.GetKeyDown(KeyCode.Mouse0) && !tpos.Contains(pos) && water != myTileMap.GetSprite(coordinate))
        {
           //placechoptree
            if ( forest == myTileMap.GetSprite(coordinate) && 16 + ri.selectedring == 18 && ti.orderWheelOn == true)
            {
                tpos[curentcell] = pos;
                Instantiate(testbuilding, pos, idk);
                curentcell++;
            }
            if (rockeyterrain == myTileMap.GetSprite(coordinate) && 16 + ri.selectedring == 17 && ti.orderWheelOn == true)
            {
                tpos[curentcell] = pos;
                Instantiate(testbuilding, pos, idk);
                curentcell++;
            }

//general
            if (  ti.orderWheelOn == false)
            {

                tpos[curentcell] = pos;
                GameObject MyBuilding = Instantiate(testbuilding, pos, idk);

                //this creates the building and set it to an object so it is a child
                MyBuilding.transform.position = new Vector3(MyBuilding.transform.position.x, MyBuilding.transform.position.y - 0.10567f, MyBuilding.transform.position.z);
                MyBuilding.transform.parent = parrentObj.transform;

                curentcell++;
            }
        }
   
    }

    //changes the list for 1 sec
    public void takeOutThePos()
    {
        for (int i = 0;i < childTrans.Length - 1; i++)
        {
            buildingsPosX.Add(childTrans[i + 1].position.x);
            buildingsPosY.Add(childTrans[i + 1].position.y);
            Names.Add("fire");
            Debug.Log("this is i :" + i + " of buildingsPosX " + buildingsPosX.Count);
        }

        Invoke("resetTheList", 1f);

    }
    //resets the list
    void resetTheList()
    {
        buildingsPosX = new List<float>();
        buildingsPosY = new List<float>();
        Names = new List<string>();
    }
    //this create the buildings after loading note that you should have the fire bar selected in the game
    public void makeBuilding(float posX,float posY, string name)
    {
        GameObject MyBuilding = Instantiate(testbuilding, new Vector3(posX,posY, -0.9500039f), idk);
        MyBuilding.transform.parent = parrentObj.transform;
    }
}
    


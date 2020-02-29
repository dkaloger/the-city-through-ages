using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using  UnityEngine.Tilemaps;
public class placebuildings : MonoBehaviour
{
    public bool pauseMenuOn = true;
    public GameObject destroyBuildingPos;
    public Transform[] childTrans;
    public destroy[] childScripts;
    public GameObject parrentObj;
    public List<float> buildingsPosX = new List<float>();
    public List<float> buildingsPosY = new List<float>();
    public List<string> Names = new List<string>();
    [SerializeField]
public GameObject testbuilding;
[SerializeField]
FX_Player gf;
[SerializeField]

Vector3 pos;
[SerializeField] Quaternion idk;
[SerializeField]
    Vector3 mi ;

    Transform mapt;
[SerializeField]
Vector3 maposset;
[SerializeField]
FX_MapGen mpp;

public Vector3[] tpos;
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
    [SerializeField]
    cost placecost;
 public   bool justplaced;
  public  GameObject congratsforanvil;
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
        Debug.Log(ti.curTier * 8 + ri.selectedring + "this is select ring number");
        justplaced = false;
        //child trans takes  the transforms of the buildings every frame
        childTrans = parrentObj.GetComponentsInChildren<Transform>();
        childScripts = parrentObj.GetComponentsInChildren<destroy>();
        if (ti.orderWheelOn == false)
        {
            testbuilding = buildings[ti.curTier * 8 + ri.selectedring];
            Debug.Log(ti.curTier * 8 + ri.selectedring);
        }
        else if (ti.orderWheelOn == true)
        {
            testbuilding = buildings[24 + ri.selectedring];
            Debug.Log(16 + ri.selectedring);
        }
      
        pos = new Vector3(gf.TargetHex.position.x, gf.TargetHex.position.y, gf.TargetHex.position.z - 2f);
        posi.x = (int)pos.x;
        posi.y = (int)pos.y;
        posi.z = 45;
        //theproblemishere l98-101
        //Get position of the mouseclick
        mi = Input.mousePosition;
        mi.z = -73;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Convert position of the mouseclick to the position of the tile located at the mouseclick
        Debug.Log("s");
        Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
        //Display tile position in log

        //Display the sprite value of the tile in log *SUCCESS*
        Debug.Log("l04");
        if (Input.GetKeyDown(KeyCode.Mouse0) && tpos.Contains(pos) == false && water != myTileMap.GetSprite(coordinate) && placecost.canafford == false && pauseMenuOn == false)
        {
            Debug.Log("l07");
           //placechoptree
            if ( forest == myTileMap.GetSprite(coordinate) && 16 + ri.selectedring == 18 && ti.orderWheelOn == true)
            {
                tpos[curentcell] = pos;
                GameObject MyBuilding =  Instantiate(testbuilding, pos, idk);
                MyBuilding.transform.position = new Vector3(MyBuilding.transform.position.x, MyBuilding.transform.position.y - 0.10567f, MyBuilding.transform.position.z);
                MyBuilding.transform.parent = parrentObj.transform;
                curentcell++;
            }
            else if (rockeyterrain == myTileMap.GetSprite(coordinate) && 16 + ri.selectedring == 17 && ti.orderWheelOn == true)
            {
                tpos[curentcell] = pos;
                GameObject MyBuilding =  Instantiate(testbuilding, pos, idk);
                MyBuilding.transform.position = new Vector3(MyBuilding.transform.position.x, MyBuilding.transform.position.y - 0.10567f, MyBuilding.transform.position.z);
                MyBuilding.transform.parent = parrentObj.transform;
                curentcell++;
            }
//general
            else if (  ti.orderWheelOn == false)
            {
                ti.placedABuilding(testbuilding.name);
                tpos[curentcell] = pos;        
                GameObject MyBuilding = Instantiate(testbuilding, pos, idk);
                //this creates the building and set it to an object so it is a child
                MyBuilding.transform.position = new Vector3(MyBuilding.transform.position.x, MyBuilding.transform.position.y - 0.10567f, MyBuilding.transform.position.z);
                MyBuilding.transform.parent = parrentObj.transform;
                curentcell++;
                if (testbuilding.name == "anvil") MyBuilding.transform.localScale = new Vector3(2, 2, 1);
            }
            //check for anvil
            if (testbuilding.name == "anvil")
            {
                congratsforanvil.SetActive(true);
            }
            justplaced = true;
         
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            takeOutThePos();

            destroyBuilding();
        }
   
    }

    public void destroyAllBuildings()
    {
        curentcell = 0;
        for (int i = 0; i < tpos.Length; i++)
        {
            tpos[i] = new Vector3();
        }
        for (int i = 0; i < childScripts.Length; i++)
        {
            childScripts[i].destroyObjetct();
            if (i == childScripts.Length - 1)
            {
                return;
            }
        }

    }

    void destroyBuilding()
    {
        GameObject destroy = Instantiate(destroyBuildingPos, pos, idk);
        destroy.transform.position = new Vector3(destroy.transform.position.x, destroy.transform.position.y - 0.10567f, destroy.transform.position.z);
        destroy.transform.parent = parrentObj.transform;
        for (int i = 0; i < childScripts.Length; i++)
        {
            if (destroy.transform.position.x == buildingsPosX[i] && destroy.transform.position.y == buildingsPosY[i])
            {
                childScripts[i].destroyObjetct();

            }
        }
        for (int i = 0; i < tpos.Length; i++)
        {
            if (tpos[i].x == pos.x && tpos[i].y == pos.y)
            {
                tpos[i] = new Vector3();
            }
        }
        Destroy(destroy, 0);
    }
    //changes the list for 1 sec
    public void takeOutThePos()
    {
        for (int i = 0;i < childTrans.Length - 1; i++)
        {
            buildingsPosX.Add(childTrans[i + 1].position.x);
            buildingsPosY.Add(childTrans[i + 1].position.y);
            Names.Add(childTrans[i + 1].name);
            Debug.Log("this is i :" + i + " of buildingsPosX " + buildingsPosX.Count);
        }
        Invoke("resetTheList", 0.3f);
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
        if (name == "fire(Clone)")
        {
            GameObject MyBuilding = Instantiate(buildings[1], new Vector3(posX,posY, -0.9500039f), idk);
            MyBuilding.transform.parent = parrentObj.transform;
            curentcell++;
            tpos[childTrans.Length] = new Vector3(posX, posY, -0.9500039f);
        }
        else if (name == "tent(Clone)")
        {
            GameObject MyBuilding = Instantiate(buildings[2], new Vector3(posX, posY, -0.9500039f), idk);
            MyBuilding.transform.parent = parrentObj.transform;
            curentcell++;
            tpos[childTrans.Length] = new Vector3(posX, posY, -0.9500039f);
        }
        else if (name == "anvil(Clone)")
        {
            GameObject MyBuilding = Instantiate(buildings[0], new Vector3(posX, posY, -0.9500039f), idk);
            MyBuilding.transform.parent = parrentObj.transform;
            MyBuilding.transform.position = new Vector3(2, 2, 1);
            curentcell++;
            tpos[childTrans.Length] = new Vector3(posX, posY, -0.9500039f);
        }
    }
}
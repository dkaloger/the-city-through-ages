using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebuilding : MonoBehaviour
{
    public GameObject gridObj;
    public Transform tileMapPos;
    List<Vector3Int> objPos = new List<Vector3Int>();
    Vector3 point;
    public GameObject testBuilding;
    public bool orderWheelOnP = false;
    private int tiers = 0;
    public Tilemap buildings;
    Vector3Int clickedpos;
    public Tile[] Buldings;
    public GameObject techTree;
    [SerializeField]
    Canvas myCanvas;
    Vector2 pos;
    public Camera maincam;
    public Vector3 correction;
    //  void Update()
    //   {
    //     RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);
    //        clickedpos.x = (int)Mathf.Round(myCanvas.transform.TransformPoint(pos).y) + (int) Mathf.Round(correction.x);
    //     clickedpos.y = (int)Mathf.Round(myCanvas.transform.TransformPoint(pos).x)+(int)Mathf.Round(correction.y) ;
    //    clickedpos.z = (int)myCanvas.transform.TransformPoint(pos).z;
    //   if (Input.GetKeyDown(KeyCode.Space) && maincam.GetComponent<Camera>().orthographicSize < 3.735543)
    //    {
    //       buildings.SetTile(clickedpos, Buldings[buildingWheel.GetComponent<glowmaster>().selectedring]);
    //      Debug.Log(clickedpos);
    //     }

    // }
    [SerializeField]
    Tilemap tilemp; 
    void Update() {

        //point.x = (int)Camera.main.ScreenToWorldPoint(Input.mousePosition.x);
        point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //point = (int)Input.mousePosition.y;

        if (Input.GetMouseButton(0) && orderWheelOnP == false) {

            if ((int)point.y % 1 == 0.5 && (int)point.x == 0.25)
            {
                var myBuilding = Instantiate(testBuilding, new Vector3(0.01F+ (int)point.x, (int)point.y, 1), Quaternion.identity);
                myBuilding.transform.parent = gridObj.transform;
                techTree.GetComponent<techTree>().addBuilding(GetComponent<glowmaster>().selectedring - 1);
            }
        }

            //Vector3Int selectedTile = tilemp.WorldToCell(point);
            //tilemp.SetTile(selectedTile, Buldings[GetComponent<glowmaster>().selectedring -1 + tiers]);
            //var myBuilding = Instantiate(testBuilding, new Vector3(0.01F+ (int)point.x, (int)point.y, 1), Quaternion.identity);
            //myBuilding.transform.parent = gridObj.transform;
            //float decimalPart = 2.55F % 1;
            //Debug.Log(decimalPart);
            //techTree.GetComponent<techTree>().addBuilding(GetComponent<glowmaster>().selectedring - 1);
     }

    public void tierChange(int tier)
    {
        tiers = tier * 8;
    }
}

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
    void Update()
    {
        float double_value = -30.555F;
        Debug.Log((int)((double_value - (int)double_value) * 100) + "this is a test");
        float decimalPart = 22.45F;
        decimalPart.ToString("F0" + "this should show 22");
        Debug.Log(Mathf.Round(decimalPart));
        //point.x = (int)Camera.main.ScreenToWorldPoint(Input.mousePosition.x);
        point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //point = (int)Input.mousePosition.y;

        if (Input.GetMouseButton(0) && orderWheelOnP == false)
        {
            //if ((int)point.y % 1 == 0.5F && (int)point.x % 1 == 0.25F || (int)point.x % 1 == 0.75F)
            var myBuilding = Instantiate(testBuilding, new Vector3(point.x, point.y, 1), Quaternion.identity);
            myBuilding.transform.parent = gridObj.transform;
            techTree.GetComponent<techTree>().addBuilding(GetComponent<glowmaster>().selectedring - 1);
            if (myBuilding.transform.position.y - myBuilding.transform.position.y * 1000 == 50)
            {

            }
            else if (((myBuilding.transform.position.y - myBuilding.transform.position.y) * 100) > 50)
            {
                //Debug.Log("your made it yeah!");
                if (((myBuilding.transform.position.x - myBuilding.transform.position.x) * 100) >= 50)
                {
                    Debug.Log("y1 x1");
                    //Vector3 MyBuildPos;
                    //MyBuildPos.x = Mathf.Round(myBuilding.transform.position.x - 25);
                    //MyBuildPos.y = Mathf.Round(myBuilding.transform.position.y - 50);
                    //MyBuildPos.z = Mathf.Round(myBuilding.transform.position.z);
                    // myBuilding.transform.position = MyBuildPos;
                }
                else if (((myBuilding.transform.position.x - myBuilding.transform.position.x) * 100) < 50)
                {
                    Debug.Log("y1 x2");
                    //Vector3 MyBuildPos;
                    //MyBuildPos.x = Mathf.Round(myBuilding.transform.position.x + 25);
                    //MyBuildPos.y = Mathf.Round(myBuilding.transform.position.y - 50);
                    //MyBuildPos.z = Mathf.Round(myBuilding.transform.position.z);
                    //myBuilding.transform.position = MyBuildPos;
                }
            }//y case 1
            else if (((myBuilding.transform.position.y - myBuilding.transform.position.y) * 100) < 50)
            {
                if ((int)((myBuilding.transform.position.x - (int)myBuilding.transform.position.x) * 100) < 50)
                {
                    Debug.Log("y2 x1");
                    //Vector3 MyBuildPos;
                    //MyBuildPos.x = Mathf.Round(myBuilding.transform.position.x);
                    //MyBuildPos.y = Mathf.Round(myBuilding.transform.position.y);
                    //MyBuildPos.z = Mathf.Round(myBuilding.transform.position.z);
                    //myBuilding.transform.position = MyBuildPos;
                }
                else if ((int)((myBuilding.transform.position.x - (int)myBuilding.transform.position.x) * 100) >= 50)
                {
                    Debug.Log("y2 x2");
                    //Vector3 MyBuildPos;
                    //MyBuildPos.x = Mathf.Round(myBuilding.transform.position.x - 0.5F);
                    //MyBuildPos.y = Mathf.Round(myBuilding.transform.position.y);
                    //MyBuildPos.z = Mathf.Round(myBuilding.transform.position.z);
                    //myBuilding.transform.position = MyBuildPos;
                }
            }//y case 2
            Debug.Log((myBuilding.transform.position.y - myBuilding.transform.position.y) * 100);
            //if (myBuilding.transform.position.y - myBuilding.transform.position.y * 1000 == 50)
        }
    }

        //Vector3Int selectedTile = tilemp.WorldToCell(point);
        ////tilemp.SetTile(selectedTile, Buldings[GetComponent<glowmaster>().selectedring -1 + tiers]);
        //var myBuilding = Instantiate(testBuilding, new Vector3((int)point.x, (int)point.y, 1), Quaternion.identity);
        //myBuilding.transform.parent = gridObj.transform;
        //float decimalPart = 99.55F % 1F;
        //Debug.Log(decimalPart +"this is the line i found on internet");
        // float double_value = 0.5F;
        //Debug.Log((int)((double_value - (int)double_value) * 100));
        //Debug.Log((int)point.x + "x" + (int)point.y + "y" + (int)point.z + "z");
        //Debug.Log(System.Math.Ceiling(System.Math.Log10(22.55F)) + "this should show 2");
        //Debug.Log(decimalPart.ToString("F0" + "this should show 22"));
        //techTree.GetComponent<techTree>().addBuilding(GetComponent<glowmaster>().selectedring - 1);

    public void tierChange(int tier)
    {
        tiers = tier * 8;
    }
}

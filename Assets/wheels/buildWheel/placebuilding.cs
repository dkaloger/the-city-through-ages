using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebuilding : MonoBehaviour
{

    Vector3 MyBuildPos;
    bool isInList2 = false;
    float var = 1.25f;
    List<float> buildingPosXTest = new List<float>();
    bool Bool = false;
    int testInt = 0;

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

        if (testInt < 200)
        {
            point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            buildingPosXTest.Add(testInt * 1.5f + 0.25f);
            testInt++;

            var myBuilding = Instantiate(testBuilding, new Vector3(testInt * 1.5f + 100.25f, point.y, 1), Quaternion.identity);

        }//basicly a for loop the for loop just hated me

        bool isInList = buildingPosXTest.IndexOf(0.25f) != -1;//checks if the num exits;

        Debug.Log(buildingPosXTest[0]);

        Debug.Log(isInList);

        //float test = 51f;
        //Debug.Log(test % 2);
        //float double_value = -30.555F;
        //Debug.Log((int)((double_value - (int)double_value) * 100) + "this is a test");
        //float decimalPart = 22.45F;
        //decimalPart.ToString("F0" + "this should show 22");
        //Debug.Log(Mathf.Round(decimalPart));
        //point.x = (int)Camera.main.ScreenToWorldPoint(Input.mousePosition.x);
        point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //point = (int)Input.mousePosition.y;

        if (Input.GetMouseButton(0) && orderWheelOnP == false)
        {
                //if ((int)point.y % 1 == 0.5F && (int)point.x % 1 == 0.25F || (int)point.x % 1 == 0.75F)
                var myBuilding = Instantiate(testBuilding, new Vector3(point.x, point.y, 1), Quaternion.identity);
                //myBuilding.transform.parent = gridObj.transform;
                float myCheckPosY = myBuilding.transform.position.y;
                float myCheckPosY2 = Mathf.Floor(myCheckPosY);
                myCheckPosY = myCheckPosY - myCheckPosY2;
                float myCheckPosX = myBuilding.transform.position.x;
                float myCheckPosX2 = Mathf.Floor(myCheckPosX);
                myCheckPosX = myCheckPosX - myCheckPosX2;
                float xUnEven = myCheckPosX % 2;
                float comTest1 = 22.55f;
                float comTest2 = 22.66f;
                float test2 = 1.5f;
                float test = 0;
                Debug.Log(comTest2.CompareTo(comTest1) + " com thing");//this returns -1 or 1,  1 if is the first is greater than the other the other is the oppersit
                //Debug.Log(myCheckPosX);
        
                techTree.GetComponent<techTree>().addBuilding(GetComponent<glowmaster>().selectedring - 1);
                if (myCheckPosY >= 0.5)
                {

                    //Debug.Log("you made it to y1");
                    if (myCheckPosX >= 0.5)
                    {
                        float check1 = Mathf.Floor(myBuilding.transform.position.x) + 0.25f;
                        float check2 = Mathf.Floor(myBuilding.transform.position.x) + 1.25f;
                        float check3 = Mathf.Floor(myBuilding.transform.position.x) + 0.75f;
                        float check4 = Mathf.Floor(myBuilding.transform.position.x) + 1.75f;
                        //Debug.Log("you made it to y1 x1");
                        //MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 1.75f;
                        //MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
                        //MyBuildPos.z = 1;

//                        if (isInList2 = buildingPosXTest.IndexOf(check1) != -1)
//                        {
//                            MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 0.25f;
//                            MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
//                            MyBuildPos.z = 1;
//                        }
//                        else if (isInList2 = buildingPosXTest.IndexOf(check2) != -1)
//                        {
//                            MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 1.25f;
//                            MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
//                            MyBuildPos.z = 1;
//                        }
                        if (isInList2 = buildingPosXTest.IndexOf(check3) != -1)
                        {
                            MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 0.75f;
                            MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
                            MyBuildPos.z = 1;
                        }
                        else if (isInList2 = buildingPosXTest.IndexOf(check4) != -1)
                        {
                            MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 1.75f;
                            MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
                            MyBuildPos.z = 1;
                        }
                        myBuilding.transform.position = MyBuildPos;
                }
                    else if (myCheckPosX < 0.5)
                    {

                            float check1 = Mathf.Floor(myBuilding.transform.position.x) + 0.25f;
                            float check2 = Mathf.Floor(myBuilding.transform.position.x) + 1.25f;
                            float check3 = Mathf.Floor(myBuilding.transform.position.x) + 0.75f;
                            float check4 = Mathf.Floor(myBuilding.transform.position.x) + 1.75f;

//                            Debug.Log("you made it to y1 x2");
//                            Vector3 MyBuildPos;
//                            MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 0.25f;
//                            MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
//                            MyBuildPos.z = 1;
//                            myBuilding.transform.position = MyBuildPos;

                           if (isInList2 = buildingPosXTest.IndexOf(check1) != -1)
                           {
                                MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 0.25f;
                                MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
                                MyBuildPos.z = 1;
                           }
                           else if (isInList2 = buildingPosXTest.IndexOf(check2) != -1)
                           {
                                MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 1.25f;
                                MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y) + 0.5f;
                                MyBuildPos.z = 1;
                           }

                }
                }//y case 1
                else if (myCheckPosY < 0.5)
                {
                    myBuilding.SetActive(false);
                    //Debug.Log("you made it to y2");
                    if (myCheckPosX < 0.5)
                    {
                        Debug.Log("you made it to y2 x1");
                        Vector3 MyBuildPos;
                        MyBuildPos.x = Mathf.Round(myBuilding.transform.position.x);
                        MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y);
                        MyBuildPos.z = Mathf.Round(myBuilding.transform.position.z);
                        myBuilding.transform.position = MyBuildPos;
                    }
                    else if (myCheckPosX >= 0.5)
                    {
                        Debug.Log("you made it to y2 x2");
                        Vector3 MyBuildPos;
                        MyBuildPos.x = Mathf.Floor(myBuilding.transform.position.x) + 50;
                        MyBuildPos.y = Mathf.Floor(myBuilding.transform.position.y);
                        MyBuildPos.z = 1;
                        myBuilding.transform.position = MyBuildPos;

                    }
                }//y case 2

                //float test = myBuilding.trsform.position.y - myBuilding.transform.position.y * 100;
                //Debug.Log(myCheckPosY + " this should remove the hole numbers");
                //Debug.Log(System.Math.Truncate(22.99999999m));
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

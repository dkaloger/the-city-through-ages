using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebuilding : MonoBehaviour
{
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

        
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0)) {
            Vector3Int selectedTile = tilemp.WorldToCell(point);
            tilemp.SetTile(selectedTile, Buldings[GetComponent<glowmaster>().selectedring -1]);
            techTree.GetComponent<techTree>().addBuilding(GetComponent<glowmaster>().selectedring - 1);} 
     }
}

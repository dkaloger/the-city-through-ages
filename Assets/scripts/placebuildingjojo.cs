using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebuildingjojo : MonoBehaviour
{
    [SerializeField]
    private Vector3Int clickedpos;
    public Tilemap buildings;
    public Tile highlightTile;
    public Tile[] Buldings;
    public Vector3 test;
    public float correction;
    public GameObject buildingWheel;
    public int addX = 50;
    public int addY = -50;
    public GameObject TechTree;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Camera>().orthographicSize < 3.735543)
        {

            //correction = transform.position.y / 3.141592653589793238462643383279502884197169399375105f;

            //clickedpos.x = (int)transform.position.x;
            //clickedpos.y = (int)transform.position.y + (int)correction;
            //clickedpos.z = (int)transform.position.z;

            clickedpos.x = (int)Input.mousePosition.x + (int)buildings.transform.position.x;
            clickedpos.y = (int)Input.mousePosition.y + (int)buildings.transform.position.y;
            clickedpos.z = (int)Input.mousePosition.z;

            //buildings.SetTile(clickedpos, highlightTile);

            buildings.SetTile(clickedpos, Buldings[buildingWheel.GetComponent<glowmaster>().selectedring - 1]);

            TechTree.GetComponent<techTree>().addBuilding(buildingWheel.GetComponent<glowmaster>().selectedring - 1);

            //Debug.Log(Input.mousePosition.x);
            //Debug.Log(Input.mousePosition.y);

        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebuildingjojo2 : MonoBehaviour
{
    [SerializeField]
    private Vector3Int clickedpos;
    public Tilemap buildings;
    public Tile highlightTile;
    public Tile[] Buldings;
    public Vector3 test;
    public float correction;
    public GameObject buildingWheel;
    public GameObject TechTree;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Camera>().orthographicSize < 3.735543)
        {

           

            clickedpos.x = (int)transform.position.y;
            clickedpos.y = (int)transform.position.x ;
            clickedpos.z = (int)transform.position.z;

            buildings.SetTile(clickedpos, Buldings[buildingWheel.GetComponent<glowmaster>().selectedring -1]);

            TechTree.GetComponent<techTree>().addBuilding(buildingWheel.GetComponent<glowmaster>().selectedring -1);

            Debug.Log(clickedpos.x);
            //Debug.Log(clickedpos.y);

        }

    }
}
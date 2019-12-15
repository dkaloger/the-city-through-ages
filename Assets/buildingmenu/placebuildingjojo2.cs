using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebuildingjojo2 : MonoBehaviour
{
    [SerializeField]
     Vector3Int clickedpos;
    private Vector3 clickedposf;
    public Tilemap buildings;
    public Tile highlightTile;
    public Tile[] Buldings;
    public Vector3 test;
    public float correction;
    public GameObject buildingWheel;
    public GameObject TechTree;
public Camera maincam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && maincam.GetComponent<Camera>().orthographicSize < 3.735543)
        {
            correction = transform.position.x / 3f;


            clickedposf.x = Mathf.Round(transform.position.y);
            clickedposf.y = Mathf.Round(transform.position.x) + Mathf.Round(correction);
            clickedposf.z = transform.position.z;
            clickedpos.y = (int)clickedposf.y;
            clickedpos.x = (int)clickedposf.x;
            clickedpos.z = (int)clickedposf.z;
            buildings.SetTile(clickedpos, Buldings[buildingWheel.GetComponent<glowmaster>().selectedring ]);

          //  TechTree.GetComponent<techTree>().addBuilding(buildingWheel.GetComponent<glowmaster>().selectedring );

            Debug.Log(clickedpos.x);
            //Debug.Log(clickedpos.y);

        }

    }
}
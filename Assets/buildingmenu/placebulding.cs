using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class placebulding : MonoBehaviour
{ 
    [SerializeField]
    private Vector3Int clickedpos;
    public Tilemap buildings;
    public Tile highlightTile;
    public Vector3 test;
    public float correction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Camera>().orthographicSize < 3.735543)
        {

            correction = transform.position.y / 3.141592653589793238462643383279502884197169399375105f;
           
 clickedpos.x = (int)transform.position.x;
            clickedpos.y = (int)transform.position.y + (int)correction;
            clickedpos.z = (int)transform.position.z ;
            buildings.SetTile(clickedpos, highlightTile);
        }
        
           
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using  UnityEngine.Tilemaps;
public class placebuildings : MonoBehaviour
{
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
    public Grid grid;
    [SerializeField]
    Tilemap myTileMap;
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
        pos = new Vector3(gf.TargetHex.position.x, gf.TargetHex.position.y, gf.TargetHex.position.z - 2f);
        posi.x = (int)pos.x;
        posi.y = (int)pos.y;
        posi.z = 45 ;
     
        //Get position of the mouseclick
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Convert position of the mouseclick to the position of the tile located at the mouseclick
        Vector3Int coordinate = grid.WorldToCell(mouseWorldPos);
        //Display tile position in log
        Debug.Log(coordinate);
        //Display the sprite value of the tile in log *SUCCESS*
        
        if(Input.GetKeyDown(KeyCode.Mouse0)&& !tpos.Contains(pos) &&water != myTileMap.GetSprite(coordinate)){
           
           


            tpos[curentcell] = pos;
            Instantiate(testbuilding,pos,idk );
            curentcell++;
        }
    }
}

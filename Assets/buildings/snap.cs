using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{

    public float gridSize = 1.5f;
    private Vector3 snapPos;

    void Update()
    {
        float nowGrid = 1f / gridSize;

        snapPos.x = Mathf.Round(transform.position.x * nowGrid) / nowGrid;

    }
}

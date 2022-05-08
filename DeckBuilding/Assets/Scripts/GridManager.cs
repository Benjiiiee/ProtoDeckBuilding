using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private float gridSpacingX = 1f;
    [SerializeField] private float gridSpacingY = -1f;
    [SerializeField] private GridTile gridTile;
    [SerializeField] private Transform StartPos;
    private GridTile[] tileArray = new GridTile[32];

    void Start()
    {
        SpawnArray();
    }

    private void SpawnArray()
    {
        GridTile temp = null;
        float posX = 0;
        float posY = 0;

        for(int i = 0; i < tileArray.Length; i++)
        {
            temp = Instantiate(gridTile, StartPos.position + new Vector3(posX * gridSpacingX, posY * gridSpacingY), Quaternion.identity);

            posX += 1;
            if((i + 1) % 8 == 0)
            {
                posX = 0;
                posY += 1;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    List<Tile>  tiles = new List<Tile>();
    public GameObject tile;
    GameObject[,] map = new GameObject[3, 3];

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                tiles.Add(new Tile(i, j));
                Instantiate(tile, new Vector3(i * 1.2f, 0, j * 1.2f), Quaternion.identity);
            }
        }
    }
}

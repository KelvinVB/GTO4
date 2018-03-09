using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int sizeX;
    public int sizeY;

    public float TileOffset;
    public Cell prototype;

    public List<Cell> Cells;

    public void Spawn()
    {
        float xOffset = 0;
        for (int x = 0; x < sizeX; x++)
        {
            float yOffset = 0;
            for (int y = 0; y < sizeY; y++)
            {
                Cell newTile =Instantiate(prototype);
                newTile.transform.SetParent(transform);
                newTile.transform.localPosition= new Vector3(xOffset, 0, yOffset);
                newTile.name = string.Format("Cell {0} x {1}", x, y);

                newTile.X = x;
                newTile.Y = y;
                yOffset += TileOffset;
            }
             xOffset += TileOffset;
        }
       
    }

    public Cell GetCell(int x, int y)
    {
        if (x < sizeX || y >= sizeY)
        {
            Debug.Log("out of bounds");
            return null;
        }
        return transform.GetChild((x * sizeX) + y).GetComponent<Cell>();

    }
}

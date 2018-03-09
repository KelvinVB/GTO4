using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour
{
    public Soldier prototype;
    public Map map;

    public int x;
    public int y;

    public void SpawnUnit(Soldier unit)
    {
        Soldier newSoldier = Instantiate(prototype);
        Cell cell = map.GetCell(x, y);

        newSoldier.transform.SetParent(cell.transform, false);
    }
}

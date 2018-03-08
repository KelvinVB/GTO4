using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour
{
    public UIScript uiScript;
    private int gold = 1000;
    private int wood = 1000;

    public void addGold()
    {
        gold += 50;
        uiScript.changeGold(gold);
    }

    public void addWood()
    {
        wood += 50;
        uiScript.changeWood(wood);
    }

    public void buySoldier()
    {
        gold -= 100;
        wood -= 100;
        uiScript.changeWood(wood);
        uiScript.changeGold(gold);
    }

    
}

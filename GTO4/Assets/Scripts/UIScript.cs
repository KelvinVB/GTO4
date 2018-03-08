using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text woodtxt;
    public Text goldtxt;

    public void changeGold(int gold)
    {
        goldtxt.text = gold.ToString();
    }

    public void changeWood(int wood)
    {
        woodtxt.text = wood.ToString();
    }
}

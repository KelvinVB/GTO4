using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Recourses : MonoBehaviour
{
    public UIScript ui;
    public int value;

    public void addAmount(int amount)
    {
        value += amount;
        updateUI();
    }

    public void removeAmount(int amount)
    {
        value -= amount;
        updateUI();
    }

    public void updateUI()
    {
        ui.changeValue(value);
    }

}

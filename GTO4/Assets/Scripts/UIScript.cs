using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text txt;
    

    public void changeValue(int value)
    {
        txt.text = value.ToString();
    }
}

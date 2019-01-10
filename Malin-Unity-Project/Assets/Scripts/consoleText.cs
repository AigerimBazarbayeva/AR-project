using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class consoleText : MonoBehaviour {

    public Text printText;

	// Use this for initialization
	void Start () {
        printText.text = "";       
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
        {
            printText.text = Input.touchCount + " number of touches right now.";
        }
        else
        {
            printText.text = "";
        }
	}
}

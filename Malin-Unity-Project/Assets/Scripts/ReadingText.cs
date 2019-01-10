using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ReadingText : MonoBehaviour, IVirtualButtonEventHandler {

    // private GameObject obj;
    public Text debugText;

    private VirtualButtonBehaviour[] vbs;

    // Use this for initialization
    void Start ()
    {
        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }

        debugText.text = "";
    }
	


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        string nameBtn = "noName";

        for (int i = 0; i < vbs.Length ; i++)
        {
            if(vbs[i] == vb)
            {
                nameBtn = vbs[i].VirtualButtonName;
            }
        }

        switch (nameBtn)
        {
            case "appleBtn":
                debugText.text = "DET FUNKAR YEY!!!";
                break;
            case "noName":
                debugText.text = "det funkar inte. for-loopen är fel.";
                break;
            default:
                debugText.text = "Det funkar inte. nameBtn = " + nameBtn;
                break;
        }



    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        debugText.text = ".";
    }
}

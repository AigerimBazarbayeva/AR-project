using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;


public class octopusSpin : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject octopus;
    public Text text;

	// Use this for initialization
	void Start () {
        GameObject virtualButtonObject = this.gameObject;
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        octopus = GameObject.Find("octopus_pink");

        if (octopus.name == "octopus_pink")
        {
            text.text = "found the gameobject";
        }
        else
        {
            text.text = "Didn't find the object.";
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //octopus.transform.Rotate(Vector3.right * Time.deltaTime);
        //octopus.transform.RotateAround(octopus.transform.position, octopus.transform.up, Time.deltaTime * 10f);
        octopus.GetComponent<Animation>().Play();
        text.text = "Should be playing animation...";
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

}

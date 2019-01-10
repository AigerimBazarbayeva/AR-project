using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ReadingSound : MonoBehaviour, IVirtualButtonEventHandler {

    public Text consoleText;
    public AudioSource sound;
    private string nameObj;

    // Use this for initialization
    void Start () {
        GameObject virtualButtonObject = this.gameObject;
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        nameObj = virtualButtonObject.name;
        consoleText.text = "";

    }
	
	public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        consoleText.text = "Pressing the button " + nameObj;
        sound.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        consoleText.text = "";
    }
}

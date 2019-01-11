using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ReadingSound : MonoBehaviour, IVirtualButtonEventHandler {

    public Text consoleText;
    public AudioSource sound;

    // Use this for initialization
    void Start () {
        GameObject virtualButtonObject = this.gameObject;
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sound.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){}
}

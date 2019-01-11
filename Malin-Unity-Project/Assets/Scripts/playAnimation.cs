using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class playAnimation : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject gameObj;
    public Text text;

    // Use this for initialization
    void Start()
    {
        GameObject virtualButtonObject = this.gameObject;
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //octopus.transform.Rotate(Vector3.right * Time.deltaTime);
        //octopus.transform.RotateAround(octopus.transform.position, octopus.transform.up, Time.deltaTime * 10f);
        gameObj.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}

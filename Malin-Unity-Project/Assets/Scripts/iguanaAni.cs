using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class iguanaAni : MonoBehaviour, IVirtualButtonEventHandler
{

    public IguanaCharacter iguanaCharacter;

    // Use this for initialization
    void Start () {
        iguanaCharacter = GetComponent<IguanaCharacter>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //octopus.transform.Rotate(Vector3.right * Time.deltaTime);
        //octopus.transform.RotateAround(octopus.transform.position, octopus.transform.up, Time.deltaTime * 10f);
        iguanaCharacter.Attack();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}

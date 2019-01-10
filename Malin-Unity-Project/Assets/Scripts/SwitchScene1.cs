using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene1 : MonoBehaviour {

    public Text debugText;

	// Use this for initialization
	void Start () {
        debugText.text = "start";

    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                debugText.text = "Hitting something.";
                //Select Stage
                if (hit.transform.name == "DuckWhite")
                {
                    //SceneManager.LoadScene("scene_I-Q");
                    debugText.text = "Hitting the duck!";
                }

                if(hit.transform.name == "octopus_pink")
                {
                    //SceneManager.LoadScene("scene_A-H");
                    debugText.text = "Hitting the octopus";
                }
            }
        //}
    }
}

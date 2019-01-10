using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackBehave;

    // Use this for initialization
    void Start()
    {
        mTrackBehave = GetComponent<TrackableBehaviour>();

        if (mTrackBehave)
        {
            mTrackBehave.RegisterTrackableEventHandler(this);
        }
      
    }

    public void OnTrackableStateChanged(
              TrackableBehaviour.Status previousStatus,
              TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            OnTrackingFound();
          
        }
        
    }
    private void OnTrackingFound()
    {
        //tex.text = "Trackable " + mTrackableBehaviour.TrackableName + " found";

        string s = "scene_" + mTrackBehave.TrackableName;

        SceneManager.LoadScene(s);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mImageTarget;

    // Use this for initialization
    void Start()
    {
        mImageTarget = GetComponent<TrackableBehaviour>();

        // check if a image target has been found and register it as an event handler.
        if (mImageTarget)
        {
            mImageTarget.RegisterTrackableEventHandler(this);
        }
      
    }

    public void OnTrackableStateChanged(
              TrackableBehaviour.Status previousStatus,
              TrackableBehaviour.Status newStatus)
    {
        // if any new image target have been detected or tracked
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            OnTrackingFound();
        }
        
    }
    private void OnTrackingFound()
    {
        // mTrackBehave.TrackableName = name of Image target
        string s = "scene_" + mImageTarget.TrackableName;

        SceneManager.LoadScene(s);
    }

}

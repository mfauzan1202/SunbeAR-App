using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARSupportChecker : MonoBehaviour
{
    public GameObject panel;
    private void Start()
    {
        panel.SetActive(true);
        if (VuforiaBehaviour.Instance.World.AnchorsSupported)
        {
            if (!VuforiaBehaviour.Instance.DevicePoseBehaviour.enabled)
            {
                Debug.LogError("The Ground Plane feature requires the Device Tracking to be started. " +
                               "Please enable it in the Vuforia Configuration or start it at runtime through the scripting API.");
                return;
            }
            panel.SetActive(false);
            Debug.Log("DevicePoseBehaviour is Active");
        }
        else
        {
            panel.SetActive(true);
        }
    }
}


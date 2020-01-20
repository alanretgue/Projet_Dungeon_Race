using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchcam : MonoBehaviour
{
    public GameObject CamFps;
    public GameObject CamTps;
    bool cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SwitchCam"))
        {
            if (cam)
            {
                cam = false;
                CamTps.SetActive(true);
                CamFps.SetActive(false);
            }
            else
            {
                cam = true;
                CamFps.SetActive(true);
                CamTps.SetActive(false);
            }
        }
    }
}

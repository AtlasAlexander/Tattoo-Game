using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TbarController : MonoBehaviour
{
    public CameraManager cameraManager;
   public GameObject prompt;

    private void Start()
    {
        cameraManager = FindAnyObjectByType<CameraManager>();
        prompt.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        { 
            prompt.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //cameraManager.TbarCamController(cameraManager.tbarCam); 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        prompt.SetActive(false);
    }
}

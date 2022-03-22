using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravelScript : MonoBehaviour
{
    private bool inPast = false;
    private bool inPresent = false;
    private bool inFuture = false;

    public GameObject followCam;

    // Update is called once per frame
    void Update()
    {
        if (inPast == false)
        {
            if (Input.GetButton("Past"))
            {
                followCam.SetActive(false);
                transform.position = new Vector3(transform.position.x, -350, transform.position.z);
                followCam.transform.position = new Vector3(followCam.transform.position.x, -350, followCam.transform.position.z);
                followCam.SetActive(true);
            }
        }

        if(inPresent == false)
        {
            if (Input.GetButton("Present"))
            {
                followCam.SetActive(false);
                transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                followCam.transform.position = new Vector3(followCam.transform.position.x, 0, followCam.transform.position.z);
                followCam.SetActive(true);
            }
        }

        if (inFuture == false)
        {
            if (Input.GetButton("Future"))
            {
                followCam.SetActive(false);
                transform.position = new Vector3(transform.position.x, 350, transform.position.z);
                followCam.transform.position = new Vector3(followCam.transform.position.x, 350, followCam.transform.position.z);
                followCam.SetActive(true);
            }
        }
    }
}

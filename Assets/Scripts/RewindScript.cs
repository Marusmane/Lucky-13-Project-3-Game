using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindScript : MonoBehaviour
{
    public bool isRewinding = false;

    List<Vector3> oldPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        oldPosition = new List<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Rewind"))
        {
            StartRewind();
        }

        if (Input.GetButtonUp("Rewind"))
        {
            StopRewind();
        }
    }

    void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
        {
            Record();
        }
    }

    void Rewind()
    {
        transform.position = oldPosition[0];
        oldPosition.RemoveAt(0);
    }

    void Record()
    {
        oldPosition.Insert(0, transform.position);
    }

    void StartRewind()
    {
        isRewinding = true;
    }

    void StopRewind()
    {
        isRewinding = false;
    }
}

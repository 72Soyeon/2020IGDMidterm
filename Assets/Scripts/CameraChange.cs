using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera myCam1;

    public Camera myCam2;
    // Start is called before the first frame update
    void Start()
    {
        myCam2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (myCam1.gameObject.active == true)
        {
            myCam1.gameObject.SetActive(false);
            myCam2.gameObject.SetActive(true);
        }
        else
        {
            myCam2.gameObject.SetActive(false);
            myCam1.gameObject.SetActive(true);

        }
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastPlayer : MonoBehaviour
{

    private RaycastHit myHit;
    public GameObject player;

    public Material [] NYCcolor1;

    Renderer rend1;
    Renderer rend2;
    Renderer rend3;
    Renderer rend4;

    
    public GameObject build1;
    public GameObject build2;
    public GameObject build3;
    public GameObject build4;

    private void Start()
    {
        rend1 = build1.GetComponent<Renderer>();
        rend2 = build2.GetComponent<Renderer>();
        rend3 = build3.GetComponent<Renderer>();
        rend4 = build4.GetComponent<Renderer>();

        rend1.enabled = true;
        rend1.sharedMaterial = NYCcolor1 [0];
        
        rend2.enabled = true;
        rend2.sharedMaterial = NYCcolor1 [0];

        rend3.enabled = true;
        rend3.sharedMaterial = NYCcolor1 [0];

        rend4.enabled = true;
        rend4.sharedMaterial = NYCcolor1 [0];

    }


    public float castingDistance = 2f;
    
    // Update is called once per frame
    void Update()
    {
    Ray myRay = new Ray(transform.position, transform.forward);
    Debug.DrawRay(myRay.origin, myRay.direction *castingDistance, Color.blue);

    if (Physics.Raycast(myRay, out myHit, castingDistance))
    {
        if (myHit.transform.gameObject.tag == "memory1")
        {
            //Debug.Log ("memory 1 hit");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("memory 1 hit");
                myHit.transform.gameObject.GetComponent<memoryControl>().TriggerMemory();
                myHit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }

        if (myHit.transform.gameObject.tag == "memory1 NYC")
        {
            if (Input.GetMouseButtonDown(0))
            {
               player.transform.position = new Vector3((float) -2.4, (float) -1.4,(float) 1.38);
                myHit.transform.gameObject.SetActive(false);
                
                rend1.sharedMaterial = NYCcolor1 [1];
                rend2.sharedMaterial = NYCcolor1 [1];
                rend3.sharedMaterial = NYCcolor1 [1];
                rend4.sharedMaterial = NYCcolor1 [1];

            }
        }
        
        
        
        //memory 2
        if (myHit.transform.gameObject.tag == "memory2")
        {
            //Debug.Log ("memory 1 hit");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("memory 2 hit");
                myHit.transform.gameObject.GetComponent<memoryControl>().TriggerMemory();
                myHit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }

        if (myHit.transform.gameObject.tag == "memory2NYC")
        {
            if (Input.GetMouseButtonDown(0))
            {
                player.transform.position = new Vector3((float) -2.4, (float) -1.4,(float) 1.38);
                myHit.transform.gameObject.SetActive(false);
                
                
            }
        }
        

    }
    
    }
    
    
}

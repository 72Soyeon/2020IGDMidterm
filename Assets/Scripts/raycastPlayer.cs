using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastPlayer : MonoBehaviour
{

    public GameObject basicInfo;

    
    //ray casting
    private RaycastHit myHit;
    public GameObject player;

    
    //반응 큐브
    public GameObject goingBack1;
    public GameObject goingBack2;
    public GameObject goingBack3;

    
    //public bench
    public GameObject water;
    
    //door
    public GameObject door;

    public GameObject bridge;
    
    // public GameObject build1;
    public GameObject build1;
    public GameObject build2;
    public GameObject build3;
    public GameObject build4;
    
    
    //color change
    public Material [] NYCcolor1;
    public Material[] waterColor;
    public Material[] doorColor;
    public Material[] bridgeColor; 

    
    //renderer
    Renderer rend1;
    Renderer rend2;
    Renderer rend3;
    Renderer rend4;

    private Renderer waterRend;
    private Renderer doorRend;
    private Renderer bridgeRend;
    
    
    //3개 이상 모이면 가는거
    private int finalCount = 0;

    
    
    private void Start()
    {
        rend1 = build1.GetComponent<Renderer>();
        rend2 = build2.GetComponent<Renderer>();
        rend3 = build3.GetComponent<Renderer>();
        rend4 = build4.GetComponent<Renderer>();

        waterRend = water.GetComponent<Renderer>();
        waterRend.enabled = true;
        waterRend.sharedMaterial = waterColor[0];
        
        doorRend = door.GetComponent<Renderer>();
        doorRend.enabled = true;
        doorRend.sharedMaterial = doorColor[0];

        bridgeRend = bridge.GetComponent<Renderer>();
        bridgeRend.enabled = true;
        bridgeRend.sharedMaterial = bridgeColor[0];
;
        rend1.enabled = true;
        rend1.sharedMaterial = NYCcolor1 [0];
        
        rend2.enabled = true;
        rend2.sharedMaterial = NYCcolor1 [0];

        rend3.enabled = true;
        rend3.sharedMaterial = NYCcolor1 [0];

        rend4.enabled = true;
        rend4.sharedMaterial = NYCcolor1 [0];
        
        
        goingBack1.SetActive(false);
        goingBack2.SetActive(false);
        goingBack3.SetActive(false);
        
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
                
                goingBack1.SetActive(true);

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

                finalCount += 1;
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
                goingBack2.SetActive(true);

            }
        }

        if (myHit.transform.gameObject.tag == "memory2NYC")
        {
            if (Input.GetMouseButtonDown(0))
            {
                player.transform.position = new Vector3((float) -2.4, (float) -1.4,(float) 1.38);
                myHit.transform.gameObject.SetActive(false);
                
                waterRend.sharedMaterial = waterColor[1];
                
                finalCount += 1;

            }
        }
        
        
        //memory 3
        if (myHit.transform.gameObject.tag == "memory3")
        {
            //Debug.Log ("memory 1 hit");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("memory 3 hit");
                
                myHit.transform.gameObject.GetComponent<memoryControl>().TriggerMemory();
                myHit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
                goingBack3.SetActive(true);

            }
        }

        if (myHit.transform.gameObject.tag == "memory3NYC")
        {
            if (Input.GetMouseButtonDown(0))
            {
                player.transform.position = new Vector3((float) -2.4, (float) -1.4,(float) 1.38);
                myHit.transform.gameObject.SetActive(false);
                
                bridgeRend.sharedMaterial = bridgeColor[1];

                
                finalCount += 1;

            }
        }


        if (finalCount == 3)
        {
            //문 색이 변하고 포탈로 쓰임
            doorRend.sharedMaterial = doorColor[1];
            door.GetComponent<BoxCollider>().enabled = false;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            basicInfo.SetActive(false);

        }

    }
    
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastPlayer : MonoBehaviour
{

    private RaycastHit myHit;
    public GameObject player;
    

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
            }
        }

    }
    
    }
    
    
}

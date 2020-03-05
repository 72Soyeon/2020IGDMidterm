using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGrounded : MonoBehaviour
{

    public float castingDistance = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1declare a ray. at the point of origin and point it DOWN
        Ray myRay = new Ray(transform.position, Vector3.down);
        
        //2 set the max distance
        //3 draw a debug line that shows the ray
        Debug.DrawRay(myRay.origin, myRay.direction * castingDistance, Color.magenta);
        
        //4shoot the raycast
        if (Physics.Raycast(myRay, castingDistance))
        {
            //Debug.Log("HIT GROUND");
        }
        else
        {
            transform.Rotate(0, 5f, 0);
        }
    }
}

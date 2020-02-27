using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rumba : MonoBehaviour
{
    public float maxRayDistance = 2f;

    public float roombaSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1 ray
        Ray roombaRay = new Ray(transform.position, transform.forward);
        
        //2 define maximum raycast distance
        Debug.DrawRay(roombaRay.origin, roombaRay.direction * maxRayDistance, Color.green);
        
        //4 shoot the raycast
        if (Physics.Raycast(roombaRay, maxRayDistance))
        {
            int randomNumber = Random.Range(0, 100);
            if (randomNumber < 50)
            {
                transform.Rotate(0, 90,0);
            }
            else
            {
                transform.Rotate(0, -90, 0);
            }
            
        }

        //just moving 
        else
        {
            transform.Translate(0, 0, Time.deltaTime * roombaSpeed);
        }

    }
    
    
}

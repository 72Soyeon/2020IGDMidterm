using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMouse : MonoBehaviour
{

    public float maxRaycastDistance = 1000f;
    public GameObject paintBrush;

    // Update is called once per frame
    void Update()
    {
        //1 define the ray
        //screen point to ray
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //2 max raycast distance
        
        //3 visualize the ray cast
        Debug.DrawRay(camRay.origin, camRay.direction*maxRaycastDistance, Color.cyan);
        
        //4a define object detection
        RaycastHit hitObject;
        
        //4 detecting the object with the ray

        if (Physics.Raycast(camRay, out hitObject, maxRaycastDistance))
        {
            //5 when hit, spawn somthing useful
            //hit = where raycast hits
            paintBrush.transform.position = hitObject.point;
            
            //5.1 paint!
            if (Input.GetMouseButton(0))
            {
                GameObject paint = Instantiate(paintBrush, hitObject.point,Quaternion.identity);
                paint.transform.SetParent(hitObject.transform);
            }
            
            //while hovering, spin the canvas
            hitObject.transform.Rotate(new Vector3(0, 0, 35*Time.deltaTime));

        }

    }
}

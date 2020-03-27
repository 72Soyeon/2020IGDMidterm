using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonPhysicsController : MonoBehaviour
{
    // get the rigid body
    public Rigidbody thisRigidbody;
    
    //make two floats
    public float forwardBackward;
    public float rightleft;
    
    //speeds
    public float speed = 10f;
    public float moveSpeed = 5f;

    public float mouseX, mouseY;

    public Vector3 inputVector;

    public GameObject greeting;
    public GameObject particle;

    private Transform cameraTransform;

    public float pitch;
    
    
    
    
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        greeting.SetActive(false);        
        particle.SetActive(false);

        cameraTransform = Camera.main.transform;

        Cursor.visible = false;
    }

    
    
    // Update is called once per frame
    void Update()
    {
        
        //마우스 센시티비티를 고려해서 3정도를 곱해주면 됨.
        mouseX = Input.GetAxis("Mouse X") * 4f ;
        mouseY = Input.GetAxis("Mouse Y") * 4f;

        transform.Rotate(0, mouseX, 0);
        
        //clamp pitch (rotation)
        pitch += mouseY;
        pitch = Mathf.Clamp(pitch, -55, 55);

        cameraTransform.localRotation = Quaternion.Euler(-pitch, 0, 0);

        
        //move control
        forwardBackward = Input.GetAxis("Vertical");
        rightleft = Input.GetAxis("Horizontal");

        inputVector = transform.forward * forwardBackward;
        inputVector += transform.right * rightleft;
        
    }
    
    

    private void FixedUpdate()
    {
        thisRigidbody.velocity = (inputVector * moveSpeed * Time.fixedDeltaTime * 50);
        //keeps the movement consistent regardless of the framing = fixed Delta Time

        //add the real gravity in order to make the camera fall at the right spped
        //thisRigidbody.velocity = (inputVector * moveSpeed * Time.fixedDeltaTime * 50) + (Physics.gravity*.69f);


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "outside")
        {
            transform.position = new Vector3((float) 78, (float) 270, (float) 275);
            greeting.SetActive(true);
            particle.SetActive(true);


        }    
    }
}
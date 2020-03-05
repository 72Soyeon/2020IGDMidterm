using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonController : MonoBehaviour
{
    public Rigidbody playerRB;

    public float forwardbackward;
    public float leftRight;

    public float speed = 5f;
    public Vector3 inputVector;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        forwardbackward = Input.GetAxis("Vertical");
        leftRight = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        inputVector = (transform.forward * forwardbackward);
        inputVector += transform.right * leftRight;
        playerRB.velocity = (inputVector * speed * Time.deltaTime * 30);
    }
}

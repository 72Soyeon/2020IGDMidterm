using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{

    /* void OnTriggerEnter(Collider other)
    
    {
        SceneManager.LoadScene("NYC");
        print("it is collided with " + other.name);
    }
    */
    
    public GameObject player;
    void OnTriggerEnter()
    {
        player.transform.position = new Vector3((float) 82.8, (float) -106.2, (float) -138);
        print(player.transform.position);
        print("it hit");

    }
}

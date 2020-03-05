using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChangetoMain : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter()
    {
        player.transform.position = new Vector3((float) 3.1, (float) -0.4,(float) 10.5);
        print("it hit??");


    }
}

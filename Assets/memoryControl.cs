using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memoryControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cursor;
    public GameObject itemScene;
    public Text itemText;
    public string itemDescription;
    public bool specialSceneOn = false;
    public GameObject player;
    public int counter = 0;
    public 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && counter == 1)
        {
            ChangeScene();
        }
    }

    public void TriggerMemory()
    {
        cursor.SetActive(false);
        itemScene.SetActive(true);
        itemText.text = itemDescription;
        
        specialSceneOn = true;

        counter += 1;
        
    }

    void ChangeScene()
    {
        if (specialSceneOn == true)
        {
            specialSceneOn = false;
            counter = 0;
                
                itemScene.SetActive(false);
                cursor.SetActive(true);
                itemText.text = " ";
                
                player.transform.position = new Vector3((float) 82.8, (float) -106.2, (float) -138);

            
        }
    }
}

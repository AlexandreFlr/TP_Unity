//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class DragonBehaviour : MonoBehaviour
{
    public GameObject worldObject ;
    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            worldObject.SendMessage("Modif");
        }
    }
}

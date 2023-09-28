//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    private AudioSource collisionSound ;
    public GameObject fx ;
    public GameObject worldObject ;
    // Start is called before the first frame update
    void Start()
    {
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
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
            worldObject.SendMessage("AddHit");
            Instantiate(fx, transform.position, Quaternion.identity);
            if(collisionSound){
                collisionSound.Play();
            }
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") {
            collision.gameObject.GetComponent<PlayerMovement>().speed = 18f;
        }
    }

    void OnTriggerStay(Collider collision)
    {
        
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player") {
            //Debug.Log("hello");
            collision.gameObject.GetComponent<PlayerMovement>().speed = 12f;
        }
    }
}

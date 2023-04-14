using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToInteract : MonoBehaviour
{
    //public GameObject PressE1;
    //public GameObject PressE2;
    //public GameObject PressE3;
    

    // Start is called before the first frame update
    void Start()
    {
        //PressE1.SetActive(true);
        //PressE2.SetActive(true);
        //PressE3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") //&& collision.gameObject.tag == "Trigger")
        {
            collision.gameObject.GetComponent<PlayerInteract>().inArea = true;
            //PressE1.SetActive(true);
            //PressE2.SetActive(true);
            //PressE3.SetActive(true);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           collision.gameObject.GetComponent<PlayerInteract>().inArea = false;
            //PressE1.SetActive(false);
            //PressE2.SetActive(false);
            //PressE3.SetActive(false);
        }
    }
}

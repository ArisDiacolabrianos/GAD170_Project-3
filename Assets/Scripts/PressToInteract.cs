using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToInteract : MonoBehaviour
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
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Area1")
        {
            collision.gameObject.GetComponent<PlayerInteract>().inArea1 = true;
        }

        //The final checkpoint is tagged Area2. This will allow the 'e' key to restart the game from the player interact script
        if(collision.gameObject.tag == "Player" && gameObject.tag == "Area2")
        {
            collision.gameObject.GetComponent<PlayerInteract>().inArea2 = true;
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
           collision.gameObject.GetComponent<PlayerInteract>().inArea1 = false;
        }
    }
}

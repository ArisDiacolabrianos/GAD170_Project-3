using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxScript : MonoBehaviour
{
    public GameObject TextHere;
    

    // Start is called before the first frame update
    void Start()
    {
        TextHere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.GetComponent<PlayerInteract>().inArea = true;
            TextHere.SetActive(true);
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
           //collision.gameObject.GetComponent<PlayerInteract>().inArea = false;
           TextHere.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInteract : MonoBehaviour
{
    public TMP_Text textTime;
    public bool inArea = false;
    public GameObject TrapDoor1;
    

    // Start is called before the first frame update
    void Start()
    {
        inArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        //player interacting - press 'e'
        if (inArea == true)
        {           
            if (Input.GetKeyDown("e"))
            {
                TrapDoor1.SetActive(false);
            }
        }
    }
}
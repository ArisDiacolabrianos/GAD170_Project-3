using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    public TMP_Text textTime;
    public bool inArea1 = false;
    public bool inArea2 = false;
    public GameObject TrapDoor1;
    public GameObject TrapDoor2;
    public GameObject Door1;
    public AudioManager soundMaster;
    

    // Start is called before the first frame update
    void Start()
    {
        inArea1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        //player interacting - press 'e'
        if (inArea1 == true)
        {           
            if (Input.GetKeyDown("e"))
            {
                TrapDoor1.SetActive(false);
                TrapDoor2.SetActive(false);
                Door1.SetActive(false);
                soundMaster.GetComponent<AudioManager>().ESound();
            }
        }

        if (inArea2 == true)
        {
            if (Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    //Checkpoint 1 Position
    //Vector3(-1.26999998,1.27999997,-4.59000015)

    //checkpoint 2 position
    //Vector3(-1.75,15.1999998,115.959999)
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnControls : MonoBehaviour
{
    public List<Vector3> checkpointLocations = new List<Vector3>(); 
    public int currentCheckpoint;
    public bool spawned = true;
    // Start is called before the first frame update
    void OnEnable()
    {
        checkpointLocations.Add(new Vector3(-0.49000001f,12.6999998f,-140.800003f));
        checkpointLocations.Add(new Vector3(-1.26999998f,1.27999997f,-4.59000015f));
        checkpointLocations.Add(new Vector3(-1.75f,15.1999998f,115.959999f));
        // Check the event bus for the checkpoint value;

        // Use above list to jump to position based on int
        //gameObject.transform.position = new Vector3(-0.49000001f,12.6999998f,-140.800003f);
        //Debug.Log("On enable running");
        //transform.Translate(checkpointLocations[EventBus.Current.WhatCheckpoint()]);
        //print(checkpointLocations[EventBus.Current.WhatCheckpoint()]);
    }

    void Start()
    {
        //Debug.Log($"{EventBus.Current.WhatCheckpoint()}");
        //currentCheckpoint = EventBus.Current.WhatCheckpoint();
        //gameObject.transform.position = checkpointLocations[currentCheckpoint];
    }

    // Update is called once per frame
    void Update()
    {
       if (spawned == false)
       {
           currentCheckpoint = EventBus.Current.WhatCheckpoint();
           gameObject.transform.position = checkpointLocations[currentCheckpoint];
           spawned = true;
       }
        
    }
}

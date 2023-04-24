using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public int thisCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            Debug.Log($"Player entering {thisCheckpoint}");
            EventBus.Current.SetCheckpoint(thisCheckpoint);
        }
    }
}

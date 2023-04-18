using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class EventBus : MonoBehaviour
{
    public static EventBus _current;

    public static EventBus Current { get { return _current;}}

    //public SingletonPlayerStats statsLink { get; private set; }

    private int checkpointReached = 0;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _current = this;
            //Adding this line to the awake on our previous example will make it IMMORTAL
            DontDestroyOnLoad(gameObject);
            //statsLink = GetComponentsInChildren<SingletonPlayerStats>();
        }
    }

    public void SetCheckpoint(int newCheckpoint) {
        checkpointReached = newCheckpoint;
        Debug.Log($"Checkpoint saved, player is at {newCheckpoint}");
    }

    public int WhatCheckpoint() {
        return checkpointReached;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    public AudioManager soundMaster;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            soundMaster.GetComponent<AudioManager>().DeathSound();
            SceneManager.LoadScene(0);
        }
        else 
        {
            Destroy(collision.gameObject);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}

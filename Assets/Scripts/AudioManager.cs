using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public AudioSource audioManager;
   public AudioClip sfx1, sfx2, sfx3, sfx4, sfx5, sfx6, sfx7;

   void Update()
   {
       
   }

   public void JumpSound()
   {
        audioManager.clip = sfx1;
        audioManager.Play();
   }

   public void ESound()
   {
        audioManager.clip = sfx2;
        audioManager.Play();
   }

   public void DeathSound()
   {
        audioManager.clip = sfx3;
        audioManager.Play();
   }

   public void VictorySound()
   {
     audioManager.clip = sfx4;
     audioManager.Play();
   }

}

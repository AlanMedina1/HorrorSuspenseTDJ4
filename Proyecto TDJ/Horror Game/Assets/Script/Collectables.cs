using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public AudioSource RosesCollect;
    //public AudioSource CandlesCollect;
    //public AudioSource LighterCollect;
    private void OnTriggerEnter(Collider other)
    {
        //PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        //puede servir
         /*if (other.CompareTag("Rosas"))
         {
             if (playerInventory != null)
             {
                 playerInventory.RosesCollected();
                 gameObject.SetActive(false);
                 RosesCollect.Play();
             }
         }*/

        /*if (other.CompareTag("Rosas"))/*playerInventory != null
        {
            playerInventory.RosesCollected();
            gameObject.SetActive(false);
            RosesCollect.Play();
        }

        if (other.CompareTag("Velas"))
        {
            playerInventory.CandlesCollected();
            gameObject.SetActive(false);
            //public AudioSource CandlesCollect;
        }
        if (other.CompareTag("Encendedor"))
        {
            playerInventory.LighterCollected();
            gameObject.SetActive(false);
            //public AudioSource LighterCollect;
        }*/

        /*if (playerInventory = null && other.CompareTag("Encendedor"))
        {
            playerInventory.LighterCollected();
            gameObject.SetActive(false);
            //public AudioSource LighterCollect;
        }*/
    }

}

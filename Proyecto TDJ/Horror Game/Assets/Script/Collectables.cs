using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public AudioSource RosesCollect;
    public AudioSource CandlesCollect;
    public AudioSource LighterCollect;

    private PlayerInventory playerInventory;
    

    void Start(){
       playerInventory = GetComponent<PlayerInventory>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

    
        
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

        //codigo sofi:
        if (other.CompareTag("Rosas")){
          playerInventory.RosesCollected();
          Destroy(other.gameObject);
          Debug.Log("entró compare tag Rosas");
          RosesCollect.Play();
        }

        if (other.CompareTag("Velas")){
          playerInventory.CandlesCollected();
          Destroy(other.gameObject);
          Debug.Log("entró compare tag Velas");
          CandlesCollect.Play();
        }

        if (other.CompareTag("Encendedor")){
          playerInventory.LighterCollected();
          Destroy(other.gameObject);
          Debug.Log("entró compare tag Encendedor");
          LighterCollect.Play();
        }
    }

}

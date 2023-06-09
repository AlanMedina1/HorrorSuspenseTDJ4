using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashlight1 : MonoBehaviour
{
    //se le agrega al objeto que se pickea
    public GameObject FlashLightOnPlayer;
    public GameObject PickUp;
   
    public AudioSource turnOnsound;
    public AudioSource turnOffsound;
    
    // Start is called before the first frame update
    void Start()
    {
        FlashLightOnPlayer.SetActive(false);
        PickUp.SetActive(false);
    }

     void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PickUp.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                FlashLightOnPlayer.SetActive(true);
                PickUp.SetActive(false);

                turnOnsound.Play();
         
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUp.SetActive(false);
    }

}


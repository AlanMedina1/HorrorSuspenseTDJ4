using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcosas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PickUp;
    public AudioSource RosesCollect;
    public AudioSource CandlesCollect;
    public AudioSource LighterCollect;
    public AudioSource GiftsCollect;

    public int CollectSteps = 0;
    public PlayerInventory playerInventory;
    void Start()
    {
        PickUp.SetActive(false);
        
        PlayerInventory playerInventory = GetComponent<PlayerInventory>();
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PickUp.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                //this.gameObject.SetActive(false);
                
                PickUp.SetActive(false);

                //tengo que chequear el objeto, cual es?
                if (this.gameObject.tag == "Rosas") {
                    
                    
                    if (CollectSteps == 0){
                       
                       this.gameObject.SetActive(false);
                       playerInventory.RosesCollected(); 
                       
                       
                       RosesCollect.Play(); //sonideishon
                       

                    }
                }

                if (this.gameObject.tag == "Velas") {
                    

                    if (CollectSteps == 1) {
                    
                     this.gameObject.SetActive(false);
                     
                     playerInventory.CandlesCollected();
                     
                   
                     CandlesCollect.Play();

                    }
                }

                if (this.gameObject.tag == "Encendedor") {
                    if (CollectSteps== 2) {
                      this.gameObject.SetActive(false);
                      playerInventory.LighterCollected();
                      
                     
                     LighterCollect.Play();

                    }
                }

                //turnOnsound.Play();
                if (this.gameObject.tag == "Regalo")
                {
                    if (CollectSteps == 3)
                    {
                        playerInventory.GiftsCollected();


                        GiftsCollect.Play();

                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (playerInventory.NumberOfRoses == 6) 
        {
            CollectSteps=1;
        }

       if(playerInventory.NumberOfCandles == 2) 
       {
            CollectSteps=2;
       }

       if (playerInventory.NumberOfLighter == 1)
       {
           CollectSteps = 3;
       }

    }
} 

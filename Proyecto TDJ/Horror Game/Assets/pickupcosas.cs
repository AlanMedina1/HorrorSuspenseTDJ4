using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcosas : MonoBehaviour
{
    // Start is called before the first frame update
    //EL LOCKED TEXT ES LO QUE SE USARIA PARA CUANDO EL OBJETO EST� BLOQUEADO
    public GameObject PickUp, lockedtext1, lockedtext2, lockedtext3;
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

                    /*if (CollectSteps != 1)
                    {
                        lockedText.SetActive(true);
                        StopCoroutine("disableText");
                        StartCoroutine("disableText");
                    }*/

                    if (CollectSteps == 1) {
                    
                     this.gameObject.SetActive(false);
                     
                     playerInventory.CandlesCollected();
                     
                   
                     CandlesCollect.Play();

                    } else if (CollectSteps == 0) {
                        lockedtext1.SetActive(true);
                        StopCoroutine("disableText");
                        StartCoroutine("disableText");
                    }
                }

                if (this.gameObject.tag == "Encendedor") {
                    if (CollectSteps== 2) {
                      this.gameObject.SetActive(false);
                      playerInventory.LighterCollected();
                      
                     
                     LighterCollect.Play();

                    } else if (CollectSteps== 1) {
                        lockedtext2.SetActive(true);
                        StopCoroutine("disableText");
                        StartCoroutine("disableText");
                    }
                }

                //turnOnsound.Play();
                if (this.gameObject.tag == "Regalo")
                {
                    if (CollectSteps == 3)
                    {
                        this.gameObject.SetActive(false);
                        playerInventory.GiftsCollected();


                        GiftsCollect.Play();

                    } else if (CollectSteps != 3) {
                        lockedtext3.SetActive(true);
                        StopCoroutine("disableText");
                        StartCoroutine("disableText");
                    }
                }
                //ESTO SER�A EL CODIGO DONDE SE ACCIONARIA LO DE EL OBJETO BLOQUEADO
                /*if (key.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                    //Sounderror.Play(); ESTO SER�A UN SONIDO DE ERROR QUE VEMOS DPS QUE PONEMOS
                }*/
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUp.SetActive(false);
    }

    //ESTO HACE QUE SE VEA EL TEXTO Y SE ACTIVE O DESACTIVE EN BASE A SI EL OBJETO EST� BLOQUEADO
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        if (lockedtext1.activeInHierarchy == true) {
            lockedtext1.SetActive(false);

        } else if (lockedtext2.activeInHierarchy == true) {
            lockedtext2.SetActive(false);

        } else if (lockedtext3.activeInHierarchy == true) {
            lockedtext3.SetActive(false);
        }
        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcosas : MonoBehaviour
{
    // Start is called before the first frame update
    //EL LOCKED TEXT ES LO QUE SE USARIA PARA CUANDO EL OBJETO EST� BLOQUEADO
    public GameObject PickUp, lockedtext1, lockedtext2, lockedtext3, logro_reg;
    public AudioSource RosesCollect;
    public AudioSource CandlesCollect;
    public AudioSource LighterCollect;
    public AudioSource GiftsCollect;

    public GameObject trigger_cuadro;

    public int CollectSteps = 0;
    public PlayerInventory playerInventory;

    public bool recogido= false;
    void Start()
    {
        PickUp.SetActive(false);
        
        PlayerInventory playerInventory = GetComponent<PlayerInventory>();
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            PickUp.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                //this.gameObject.SetActive(false);
                
                PickUp.SetActive(false);

                //tengo que chequear el objeto, cual es?
                if (this.gameObject.tag == "Rosas") {
                    
                    
                    
                       
                    this.gameObject.SetActive(false);
                    playerInventory.RosesCollected(); 
                       
                       
                    RosesCollect.Play(); //sonideishon
                       
                        
                    
                }

                if (this.gameObject.tag == "Velas") {

                   
                    
                    
                    this.gameObject.SetActive(false);
                     
                    playerInventory.CandlesCollected();
                     
                   
                    CandlesCollect.Play();

                   
                }

                if (this.gameObject.tag == "Encendedor") {
                   
                      this.gameObject.SetActive(false);
                      playerInventory.LighterCollected();
                      trigger_cuadro.SetActive(true);
                      
                     
                     LighterCollect.Play();


                   
                        /*lockedtext2.SetActive(true);
                        StopCoroutine("disableText");
                        StartCoroutine("disableText");*/ //locked text q me dejo de ejemplo
                    
                }

                //turnOnsound.Play();
                if (this.gameObject.tag == "Regalo")
                {
                    
                    
                    this.gameObject.SetActive(false);
                    playerInventory.GiftsCollected();


                    GiftsCollect.Play();

                    
                   
                    
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
 
    //corrutina q ahora no es necesaria pero q puede servir
    /*IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        if (lockedtext1.activeInHierarchy == true) {
            lockedtext1.SetActive(false);

        } else if (lockedtext2.activeInHierarchy == true) {
            lockedtext2.SetActive(false);

        } else if (lockedtext3.activeInHierarchy == true) {
            lockedtext3.SetActive(false);
        }
        
    }*/

    IEnumerator disableLogro () {
        yield return new WaitForSeconds(3.0f);
        
        if (logro_reg.activeInHierarchy == true) {
            logro_reg.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (playerInventory.NumberOfRoses == 6) 
        {
            //CollectSteps=1;
        }

       if(playerInventory.NumberOfCandles == 2) 
       {
           
           //CollectSteps=2;
       }

       if (playerInventory.NumberOfLighter == 1)
       {
           //CollectSteps = 3;
       }

       if (playerInventory.NumberOfGifts== 3){
        //logro

        if (recogido == false){
            logro_reg.SetActive(true);
            StopCoroutine("disableLogro");
            StartCoroutine("disableLogro");

            recogido = true;

        }

        

       }

    }

    
} 

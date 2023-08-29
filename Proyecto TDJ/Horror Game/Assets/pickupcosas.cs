using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupcosas : MonoBehaviour
{
    // Start is called before the first frame update
    //EL LOCKED TEXT ES LO QUE SE USARIA PARA CUANDO EL OBJETO ESTÁ BLOQUEADO
    public GameObject PickUp, lockedtext1;
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
                //ESTO SERÍA EL CODIGO DONDE SE ACCIONARIA LO DE EL OBJETO BLOQUEADO
                /*if (key.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                    //Sounderror.Play(); ESTO SERÍA UN SONIDO DE ERROR QUE VEMOS DPS QUE PONEMOS
                }*/
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUp.SetActive(false);
    }

    //ESTO HACE QUE SE VEA EL TEXTO Y SE ACTIVE O DESACTIVE EN BASE A SI EL OBJETO ESTÁ BLOQUEADO
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        lockedtext1.SetActive(false);
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

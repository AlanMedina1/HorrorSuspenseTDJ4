using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebacamara : MonoBehaviour
{
    public GameObject PickUp, key, lockedText;
    public bool interactable, toggle;
    public GameObject Objectactivateodesactivate;
    public SC_FPSController player;
    //public Animator doorAnim;
   // public AudioSource doorSound;
   // public AudioSource doorSounderror;

    void Start()
    {
        interactable = false;
    }
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Reach"))
        {
            PickUp.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            PickUp.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {  
        //if(Input.GetKeyDown(KeyCode.R)){

           // Objectactivateodesactivate.SetActive(false);

        //}
        //if(Input.GetKeyDown(KeyCode.E)){
          //  Objectactivateodesactivate.SetActive(true);
        //}
        if(interactable==true)
        {
            if(Input.GetKeyDown(KeyCode.E))
           {
                  if(key.active == false)
                {
                    toggle = !toggle;
                    if (toggle == true)
                    {
                       Objectactivateodesactivate.SetActive(false); 
                       player.enabled = true;
                    }
                    if (toggle == false)
                    {
                       Objectactivateodesactivate.SetActive(true);
                       player.enabled = false;
                    }
                    PickUp.SetActive(false);
                    interactable = false;
                }
                  if(key.active == true)
                {
                    lockedText.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                    //Objectactivateodesactivate.SetActive(true);  
                    //doorSounderror.Play();
                }
            }
        }
   
    }
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        lockedText.SetActive(false);
    }
}

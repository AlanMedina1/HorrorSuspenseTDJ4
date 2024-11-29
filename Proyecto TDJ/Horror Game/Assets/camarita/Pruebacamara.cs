using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Pruebacamara : MonoBehaviour
{
    public GameObject PickUp, key, lockedText;
    public bool interactable, toggle;
    public GameObject Objectactivateodesactivate;
    public SC_FPSController player;
    private VideoPlayer videoPlayer;
    //public Animator doorAnim;
   // public AudioSource doorSound;
   // public AudioSource doorSounderror;

    /*void Start()
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
    }*/
    void Start()
    {
         // Obtén el componente VideoPlayer
        videoPlayer = GameObject.Find("Quad").GetComponent<VideoPlayer>();
        if (videoPlayer != null)
        {
            videoPlayer.Pause(); // Asegúrate de que el video esté pausado al inicio
        }
    }


    void Update()
    {  
        
        /*
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
        }*/
   
    }
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        lockedText.SetActive(false);
    }

    public void abrirMonitor() {
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
        if (!videoPlayer.isPlaying && videoPlayer != null)
           /* {
                videoPlayer.Pause(); // Pausa si ya se está reproduciendo
            }
            else*/
            {
                videoPlayer.Play(); // Reproduce si está pausado
            } 
                    
                    


    }
}


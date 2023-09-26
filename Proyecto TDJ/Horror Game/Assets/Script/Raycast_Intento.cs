using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Intento : MonoBehaviour
{
    public GameObject logro_reg;
    public float distancia = 10f;
    public bool puedeagarrar2 = true;
    public LayerMask capainterac;
    public PlayerInventory playerInventory;
    //AUDIOS
    public AudioSource RosesCollect;
    public AudioSource CandlesCollect;
    public AudioSource LighterCollect;
    public AudioSource GiftsCollect;
    public AudioSource pickup;
    //CODIGO PARA LOS LOGROS
    public bool recogidol1 = false;

    public GameObject keypadIU;
    void Start()
    {
        //PickUp.SetActive(false);

        PlayerInventory playerInventory = GetComponent<PlayerInventory>();
    }

    //COSO DE LOGROS NO SE SOFI VOS SABES //esto es lo q desactiva el logro dsp de aparecer chinchu
    IEnumerator disableLogro()
    {
        yield return new WaitForSeconds(2.0f);

        if (logro_reg.activeInHierarchy == true)
        {
            logro_reg.SetActive(false);
        }
    }

    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * distancia, Color.red, 0.7f);
        /* Vector3 direction = Vector3.forward;
         Ray Rayito = new Ray(transform.position, transform.TransformDirection(direction * range));
         Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));*/
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, capainterac)) //, capainterac
        {
            FindObjectOfType<mensajeInteraccion>().interaccion = true;
        }
        else
        {
            FindObjectOfType<mensajeInteraccion>().interaccion = false;
        }
        /*if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, NOUSE)) //, capainterac
        {
            FindObjectOfType<mensajeInteraccion>().interaccion = false;
        }*/

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distancia))//, capainterac
            {
                if (hit.transform.gameObject.tag == "Rosas")
                {
                    hit.transform.gameObject.SetActive(false);
                    playerInventory.RosesCollected();
                    RosesCollect.Play();
                }
                if (hit.transform.gameObject.tag == "Velas")
                {
                    hit.transform.gameObject.SetActive(false);
                    playerInventory.CandlesCollected();
                    CandlesCollect.Play();
                }
                if (hit.transform.gameObject.tag == "Encendedor")
                {
                    hit.transform.gameObject.SetActive(false);
                    playerInventory.LighterCollected();
                    LighterCollect.Play();
                }
                if (hit.transform.gameObject.tag == "Regalo")
                {
                    hit.transform.gameObject.SetActive(false);
                    playerInventory.GiftsCollected();
                    GiftsCollect.Play();
                }
                //ESTO TENGO QUE SEGUIR PROBANDOLO MA�ANA
                if (hit.transform.gameObject.tag == "Llave")
                {
                    hit.transform.gameObject.SetActive(false);
                    pickup.Play();
                }
                /*
                 if (hit.transform.gameObject.tag == "Llave2")
                 {
                     hit.transform.gameObject.SetActive(false);
                    ESTO NO : playerInventory.GiftsCollected();
                     pickup.Play();
                 }
                 if (hit.transform.gameObject.tag == "Llave3")
                 {
                     hit.transform.gameObject.SetActive(false);
                     ESTO NO :playerInventory.GiftsCollected();
                     pickup.Play();
                 }*/

                 if (hit.transform.gameObject.tag == "dibujo")
                {
                    hit.collider.gameObject.GetComponent<Dibujos>().abrirCerrarDibujo();
                }

                if(hit.transform.gameObject.tag == "puerta") 
                {
                    hit.collider.gameObject.GetComponent<door>().abrirCerrarPuerta();

                }

                if(hit.transform.gameObject.tag == "florero") {
                    hit.collider.gameObject.GetComponent<floreros>().ponerFlores();

                }

                if(hit.transform.gameObject.tag == "base") {
                    hit.collider.gameObject.GetComponent<Velas1>().ponerVelas();

                }
                if(hit.transform.gameObject.tag == "base_r") {
                    hit.collider.gameObject.GetComponent<regalitos>().ponerRegalos();

                }

                if(hit.transform.gameObject.tag == "keypad") {
                    Debug.Log("keypad");
                    hit.collider.gameObject.GetComponent<openKeyPad>().abrirKeypad();

                }
            }
            /*if (Physics.Raycast(transform.position, transform.forward, out hit, distancia, capaObjetos))
            {
                GameObject objetoRecolectado = hit.transform.gameObject;

                //mano.agregar(objetoRecolectado);
                //hit.transform.gameObject.SetActive(false);
            }*/
            /* else if (Physics.Raycast(transform.position, transform.forward, out hit, distancia))
             {
                 if (hit.transform.gameObject.tag == "Regalo")
                 {

                     //mano.pieza1 = true;
                     hit.transform.gameObject.SetActive(true);
                 }
                 else if (hit.transform.gameObject.tag == "Velas")
                 {
                     //mano.pieza2 = true;
                     hit.transform.gameObject.SetActive(false);
                 }
                 else if (hit.transform.gameObject.tag == "Encendedor")
                 {
                     //mano.pieza2 = true;
                     hit.transform.gameObject.SetActive(false);
                 }
                 else if (hit.transform.gameObject.tag == "Rosas")
                 {
                     //mano.pieza2 = true;
                     hit.transform.gameObject.SetActive(false);
                 }
             }*/
        }
        //LOGROS LOGROS LOGROS LOGROS
       

        /*if (playerInventory.NumberOfGifts== 3) {
            if (recogidol1 == false)
            {
             logro_reg.SetActive(true);
             StopCoroutine("disableLogro");
             StartCoroutine("disableLogro");

             recogidol1 = true;

            }

        }*/
    }
}

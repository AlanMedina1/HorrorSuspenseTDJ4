using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floreros : MonoBehaviour
{
    public GameObject PickUp;
    public GameObject lockedtext4;
    public GameObject colector; 
    public GameObject florero_v;
    public GameObject florero_r;
    public GameObject mRosas, mVelas, mRegalos;

    private pickupcosas scriptpickup;

    //este parece que funqueishon para poenr las cosas en la mesa
    public PlayerInventory playerInventory;

    void Start()
    {
        scriptpickup = colector.GetComponent<pickupcosas>();
        PlayerInventory playerInventory = GetComponent<PlayerInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Reach"))
        {
            PickUp.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (playerInventory.NumberOfRoses == 6)
                {
                    florero_v.SetActive(false);
                    florero_r.SetActive(true);
                    CheckFinal();

                } else {
                    lockedtext4.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }
                
            } 
            
        }
    }

    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        if (lockedtext4.activeInHierarchy == true) {
            lockedtext4.SetActive(false);

        } 
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            PickUp.SetActive(false);
            
        }
    }

    void CheckFinal(){
         //tengo  q checkear si los obj estan activos en la escena y en ese caso, cargar la escena
        if ((mRosas.activeInHierarchy == true) && (mVelas.activeInHierarchy == true) && (mRegalos.activeInHierarchy == true)) {
            SceneManager.LoadScene("Partida2");
            //logro_reg.SetActive(false);
        }

    }

    //lo desactivo en caso de que necesitemos o encontremos la forma de q funque
    /*public IEnumerator NextLevelAfterWait() {
     yield return new WaitForSeconds(1.0f);
    
     SceneManager.LoadScene("Partida2");
    }*/ 
}

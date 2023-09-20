using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaccion : MonoBehaviour
{

    public GameObject PickUp;
    
    //public float interactionDistance; 
    //public GameObject interactionText;
    //public LayerMask interactionLayers; //para definir con que layer interactua y cuales no

    /*void Update(){
        RaycastHit hit;
        
        if(Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance, interactionLayers)) {
            
            if (hit.collider.gameObject.GetComponent<Dibujos>()){
                PickUp.SetActive(true);
                interactionText.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E) && CompareTag("Reach")) ;
                {
                    hit.collider.gameObject.GetComponent<Dibujos>().abrirCerrarDibujo();
                }
            }
            else{
                interactionText.SetActive(false);
            }
        }
        else{
            interactionText.SetActive(false);
        }

        
    }*/

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Reach"))
        {
            PickUp.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.GetComponent<Dibujos>().abrirCerrarDibujo();
            } 
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            PickUp.SetActive(false);
            
        }
    }
    
}

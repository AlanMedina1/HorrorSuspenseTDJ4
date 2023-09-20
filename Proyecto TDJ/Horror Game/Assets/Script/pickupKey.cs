using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupKey : MonoBehaviour
{
    //[SerializeField] private Transform objectGrabPointTransform;
    public GameObject PickUp, key;
    public AudioSource pickup;
    public bool interactable;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            PickUp.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        PickUp.SetActive(false);
        interactable = false;
    }
    void Update()
    { 
        if(interactable == true)
        {
            //Physics.Raycast(transform.position, transform.forward);
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                PickUp.SetActive(false);
                interactable = false;
                key.SetActive(false);
                pickup.Play();
            }
        }
            
    }
}

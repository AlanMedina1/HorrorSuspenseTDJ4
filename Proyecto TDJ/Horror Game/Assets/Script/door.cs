using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject PickUp;
    public bool interactable, toggle;
    public Animator doorAnim;

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            PickUp.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            PickUp.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    { 
        if(interactable==true)
        {
            if(Input.GetKeyDown(KeyCode.E))
           {
                toggle = !toggle;
                if (toggle == true)
                {
                    doorAnim.ResetTrigger("close");
                    doorAnim.SetTrigger("open");
                }
                if (toggle == false)
                {
                    doorAnim.ResetTrigger("open");
                    doorAnim.SetTrigger("close");
                }
                PickUp.SetActive(false);
                interactable = false;
            }
    }
   
}
}

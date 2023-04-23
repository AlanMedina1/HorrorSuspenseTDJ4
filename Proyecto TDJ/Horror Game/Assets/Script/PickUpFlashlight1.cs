using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashlight1 : MonoBehaviour
{
    public GameObject FlashLightOnPlayer;
    public GameObject PickUp;
    // Start is called before the first frame update
    void Start()
    {
        FlashLightOnPlayer.SetActive(false);
        PickUp.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PickUp.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                FlashLightOnPlayer.SetActive(true);

                PickUp.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUp.SetActive(false);
    }
}

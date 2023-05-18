using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public AudioSource RosesCollect;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory !=null)
        {
            playerInventory.RosesCollected();
            gameObject.SetActive(false);
            RosesCollect.Play();
        }
    }
}

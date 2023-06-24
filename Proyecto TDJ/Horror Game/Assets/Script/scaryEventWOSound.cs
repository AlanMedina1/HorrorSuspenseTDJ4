using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaryEventWOSound : MonoBehaviour
{
        public GameObject scare;
        public Collider collision;
        //public AudioSource scareSound;
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                scare.SetActive(true);
                //scareSound.Play();
                collision.enabled = false;
            }
        }
}


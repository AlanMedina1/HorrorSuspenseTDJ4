using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class regalitos : MonoBehaviour
{
    public GameObject PickUp;
    public GameObject lockedtext6;
    public GameObject colector;
    public GameObject regalo_v;
    public GameObject regalo_r;
    //este parece que funqueishon para poenr las cosas en la mesa
    public PlayerInventory playerInventory;
    private pickupcosas scriptpickup;

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
        if (other.CompareTag("Reach"))
        {
            PickUp.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (playerInventory.NumberOfGifts == 3)
                {
                    regalo_v.SetActive(false);
                    regalo_r.SetActive(true);

                }
                else
                {
                    lockedtext6.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

            }

        }
    }

    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        if (lockedtext6.activeInHierarchy == true)
        {
            lockedtext6.SetActive(false);

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

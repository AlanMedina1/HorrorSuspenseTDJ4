using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velas1 : MonoBehaviour
{
    public GameObject PickUp;
    public GameObject lockedtext5;
    public GameObject colector;
    public GameObject velas_v;
    public GameObject velas_r;

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
        if (other.CompareTag("Reach"))
        {
            PickUp.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if ((playerInventory.NumberOfCandles == 2) && (playerInventory.NumberOfLighter == 1))
                {
                    velas_v.SetActive(false);
                    velas_r.SetActive(true);

                }
                else
                {
                    lockedtext5.SetActive(true);
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }

            }

        }
    }

    IEnumerator disableText()
    {
        yield return new WaitForSeconds(1.0f);
        if (lockedtext5.activeInHierarchy == true)
        {
            lockedtext5.SetActive(false);

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

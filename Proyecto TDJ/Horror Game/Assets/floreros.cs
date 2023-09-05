using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class floreros : MonoBehaviour
{
    public GameObject PickUp;
    public GameObject lockedtext4;
    public GameObject colector; 
    public GameObject florero_v;
    public GameObject florero_r;

    private pickupcosas scriptpickup;

    void Start()
    {
        scriptpickup = colector.GetComponent<pickupcosas>();
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
                if (scriptpickup.CollectSteps>0) {
                    florero_v.SetActive(false);
                    florero_r.SetActive(true);

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
}

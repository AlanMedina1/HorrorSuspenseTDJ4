using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabler : MonoBehaviour
{
    public GameObject GameObjectTrigger;
    public Collider collision;
    // Start is called before the first frame update
    public bool primeravez = true;

    void OnTriggerEnter(Collider other)
    {
        if (primeravez == true) {

            primeravez = false;
        } else if (primeravez == false) {
            if(other.CompareTag("Player"))
            {
             GameObjectTrigger.SetActive(true);
             //scareSound.Play();
             collision.enabled = false;
            }


        

        } 
        

        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

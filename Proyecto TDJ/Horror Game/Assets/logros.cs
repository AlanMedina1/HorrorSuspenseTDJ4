using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logros : MonoBehaviour
{
    public GameObject logro_6;
    public bool logro_activo=false;
    
    // Start is called before the first frame update
    void Start()
    {

        if (logro_activo == false)
        {
            logro_6.SetActive(true);
            StopCoroutine("disableLogro");
            StartCoroutine("disableLogro");

            logro_activo = true;

        }
        
    }

    IEnumerator disableLogro()
    {
        yield return new WaitForSeconds(2.0f);

        if (logro_6.activeInHierarchy == true)
        {
            logro_6.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

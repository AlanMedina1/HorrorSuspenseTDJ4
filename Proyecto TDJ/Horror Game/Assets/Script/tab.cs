using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tab : MonoBehaviour
{
    public AudioSource paperSound;
    public GameObject tabObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
           tabObj.SetActive(true);

        }
         else
         {
            Invoke("HojaOff", 0.001f);
        }
    }

    void HojaOff()
    {
        tabObj.SetActive(false);
        paperSound.Play();
    }
    /*void HojaOn()
    {
        tabObj.SetActive(true);
        paperSound.Play();
    }

    void HojaOff()
    {
        tabObj.SetActive(false);
        paperSound.Play();
    }*/
}

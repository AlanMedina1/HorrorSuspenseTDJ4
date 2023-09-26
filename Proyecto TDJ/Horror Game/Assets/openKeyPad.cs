using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openKeyPad : MonoBehaviour
{
    public GameObject keypadIU;
    bool toggle;
    public Flashlight flashlight;
    // Start is called before the first frame update
    void Start()
    {
        Flashlight flashlight = GetComponent<Flashlight>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirKeypad() {
        toggle = !toggle;
        if (toggle == false)
        {
            keypadIU.SetActive(false);
            

            
        }
        if (toggle == true) 
        {
            keypadIU.SetActive(true);
            flashlight.LightOff();
            
        }

    }
}

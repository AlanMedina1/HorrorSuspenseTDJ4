using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject FlashlightLight;
    private bool FlashlightActive = false;
    public AudioSource turnOnsound;
    public AudioSource turnOffsound;

    // Start is called before the first frame update
    void Start()
    {
         FlashlightLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (FlashlightActive == false)
            {
                Invoke("LightOn", 0.3f);
                /*FlashlightLight.gameObject.SetActive(false);
                FlashlightActive = true;
                turnOnsound.Play();*/

            }
            else
            {
                Invoke("LightOff", 0.3f);
                /*FlashlightLight.gameObject.SetActive(true);
                FlashlightActive = false;
                turnOffsound.Play();*/
            }
        }
    }

    void LightOn()
    {
        FlashlightLight.SetActive(true);
        FlashlightActive = true;
        turnOnsound.Play();
    }
    public void LightOff()
    {
        FlashlightLight.SetActive(false);
        FlashlightActive = false;
        turnOffsound.Play();
    }
}

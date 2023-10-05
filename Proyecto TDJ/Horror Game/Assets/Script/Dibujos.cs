using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dibujos : MonoBehaviour
{
    public GameObject dibujoUI, texto_instructivo, dibujoUI1, dibujoUI2, dibujoUI3;
    public GameObject logro_4;
    public GameObject SonidoPasos;
    public GameObject SonidoCorrer;
    bool toggle; //para validar el interactuar
    public SC_FPSController player;
    public int dibujo1 = 0;
    public int dibujo2 = 0;
    public int dibujo3 = 0;
    public bool logro_4act=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void abrirCerrarDibujo() {
        toggle = !toggle;
        if (toggle == false)
        {
            dibujoUI.SetActive(false);
            texto_instructivo.SetActive(false);
            player.enabled = true;
            SonidoPasos.SetActive(true);
            SonidoCorrer.SetActive(true);
        }
        if (toggle == true) 
        {
            dibujoUI.SetActive(true);
            sobrecargoDibujo();
            texto_instructivo.SetActive(true);
            player.enabled = false;
            SonidoPasos.SetActive(false);
            SonidoCorrer.SetActive(false);
        }
    }

    void sobrecargoDibujo(){

        if(dibujoUI1.activeInHierarchy == true) {
            dibujo1 +=1;
        }
        
        if(dibujoUI2.activeInHierarchy == true) {
            dibujo2 +=1;
        }

        if(dibujoUI3.activeInHierarchy == true) {
            dibujo3 +=1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if((dibujo1>0) && (dibujo2>0) && (dibujo3>0)) {
        
           if (logro_4act == false)
           {
            logro_4.SetActive(true);
            StopCoroutine("disableLogro");
            StartCoroutine("disableLogro");

            logro_4act = true;

            }

        }
    }

    IEnumerator disableLogro()
    {
        yield return new WaitForSeconds(2.0f);

        if (logro_4.activeInHierarchy == true)
        {
            logro_4.SetActive(false);
        }
    }
}

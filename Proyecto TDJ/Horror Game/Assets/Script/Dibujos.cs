using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dibujos : MonoBehaviour
{
    public GameObject dibujoUI, texto_instructivo;
    public logroDibujo dibujoScript;

    public GameObject SonidoPasos;
    public GameObject SonidoCorrer;
    bool toggle; //para validar el interactuar
    public SC_FPSController player;
    
    // Start is called before the first frame update
    void Start()
    {
        logroDibujo dibujoScript = GetComponent<logroDibujo>();
        
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
            dibujoScript.sobrecargoDibujo();
            texto_instructivo.SetActive(true);
            player.enabled = false;
            SonidoPasos.SetActive(false);
            SonidoCorrer.SetActive(false);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if (toggle == true) {
            player.enabled = false;
        }
        
    }

    
}

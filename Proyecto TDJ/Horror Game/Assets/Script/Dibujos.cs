using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dibujos : MonoBehaviour
{
    public GameObject dibujoUI, texto_instructivo;
    public logroDibujo dibujoScript;

    //act tareas en la lista
    public bool primeraVez = true;
    public GameObject obj_lista;
    public GameObject obj_colectable;

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
        if (primeraVez==true) {
            obj_lista.SetActive(true);
            obj_colectable.SetActive(true);
            primeraVez = false;

        }

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

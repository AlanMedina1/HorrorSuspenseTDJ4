using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logroDibujo : MonoBehaviour
{
    public GameObject dibujoUI1, dibujoUI2, dibujoUI3, logro_4;

    public int dibujo1 = 0;
    public int dibujo2 = 0;
    public int dibujo3 = 0;
    public bool logro_4act=false;
    //exportar el código de logros del script de dibujos, pára q se encargue de gestionar el logro 4
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void sobrecargoDibujo(){

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
    void FixedUpdate()
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

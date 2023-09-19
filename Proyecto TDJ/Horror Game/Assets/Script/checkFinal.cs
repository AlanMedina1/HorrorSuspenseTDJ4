using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFinal : MonoBehaviour
{
    public GameObject mRosas, mVelas, mRegalos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void CheckFinal(){
         //tengo  q checkear si los obj estan activos en la escena y en ese caso, cargar la escena
        if ((mRosas.activeInHierarchy == true) && (mVelas.activeInHierarchy == true) && (mRegalos.activeInHierarchy == true)) {
            
            //logro_reg.SetActive(false);
        }

    }
}

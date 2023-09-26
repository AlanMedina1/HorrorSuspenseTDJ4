using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;


public class Keypad : MonoBehaviour
{
    public SC_FPSController player;
    public GameObject keypadOB;
    
    


    /*public GameObject animateOB;
    public Animator ANI;*/


    public Text textOB;
    public string answer = "12345";

    public AudioSource button;
    public AudioSource correct;
    public AudioSource wrong;

    public GameObject PuertaV, PuertaF;

    public bool animate;


    void Start()
    {
        keypadOB.SetActive(false);

    }


    public void Number(int number)
    {
        textOB.text += number.ToString();
        button.Play();
    }

    public void Execute()
    {
        if (textOB.text == answer)
        {
            correct.Play();
            textOB.text = "Correcto";
            PuertaF.SetActive(false);
            PuertaV.SetActive(true);


        }
        else
        {
            wrong.Play();
            textOB.text = "Wrong";
            Clear();
        }


    }

    public void Clear()
    {
        {
            textOB.text = "";
            button.Play();
        }
    }

    public void Exit()
    {
        keypadOB.SetActive(false);
        
        
        player.enabled = true;
    }

    public void FixedUpdate()
    {
        if (textOB.text == "Right")
        {
            //ANI.SetBool("animate", true);
            Debug.Log("its open");
        }


        if(keypadOB.activeInHierarchy)
        {      
            
            player.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }


}

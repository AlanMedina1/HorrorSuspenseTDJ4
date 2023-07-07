using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{ 
  /*
  
    public AudioSource RosesCollect;
    public AudioSource CandlesCollect;
    public AudioSource LighterCollect;
    
    public int CollectSteps = 0;

    private PlayerInventory playerInventory;
    

    void Start(){
       playerInventory = GetComponent<PlayerInventory>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        //if (Input.GetKey(KeyCode.E))
        //{
        if (other.CompareTag("Rosas")){
          if (CollectSteps == 0){
           playerInventory.RosesCollected();
           Destroy(other.gameObject);
           Debug.Log("entró compare tag Rosas");
           RosesCollect.Play();

          }
          

          
          
        }

        if (other.CompareTag("Velas")){
          if (CollectSteps== 1) {
          playerInventory.CandlesCollected();
          Destroy(other.gameObject);
          Debug.Log("entró compare tag Velas");
          CandlesCollect.Play();

          }
          
        }

        if (other.CompareTag("Encendedor")){
           if (CollectSteps== 2) {
          playerInventory.LighterCollected();
          Destroy(other.gameObject);
          Debug.Log("entró compare tag Encendedor");
          LighterCollect.Play();

          }
          
        }
        //}
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfRoses = 0; //{ get; private set; }
    
    public int NumberOfCandles = 0; //{ get; private set; }
    public int NumberOfLighter = 0; //{ get; private set; }
    public int NumberOfGifts = 0; 

    public UnityEvent <PlayerInventory> OnRosesCollected;
    public UnityEvent <PlayerInventory> OnCandlesCollected;
    public UnityEvent <PlayerInventory> OnLighterCollected;
    public UnityEvent<PlayerInventory> OnGiftsCollected;
    public pickupcosas pickupcosas;

    void Start(){
        

    }
    public void RosesCollected ()
    {
        NumberOfRoses++;
        Debug.Log("NumberofRoses: " + NumberOfRoses);
        OnRosesCollected.Invoke(this);

        /*if(NumberOfRoses == 6) {
            pickupcosas.CollectSteps=1;
        }*/
    }
    

    public void CandlesCollected()
    {
        //funcion velass
        NumberOfCandles++;
        OnCandlesCollected.Invoke(this);
        Debug.Log("NumberofCandles: " + NumberOfCandles);

        /*if(NumberOfCandles == 2) {
            pickupcosas.CollectSteps=2;
        }*/
    }

    public void LighterCollected()
    {
        NumberOfLighter++;
        OnLighterCollected.Invoke(this);

        /*if (NumberOfLighter == 1)
        {
            pickupcosas.CollectSteps = 3;
        }*/
    }

    public void GiftsCollected()
    {
        NumberOfGifts++;
        OnGiftsCollected.Invoke(this);
    }
}


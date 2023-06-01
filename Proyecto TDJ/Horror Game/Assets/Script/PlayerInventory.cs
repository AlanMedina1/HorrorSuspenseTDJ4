using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfRoses = 0; //{ get; private set; }
    
    public int NumberOfCandles=0; //{ get; private set; }
    public int NumberOfLighter=0; //{ get; private set; }
    
    
    public UnityEvent <PlayerInventory> OnRosesCollected;
    public UnityEvent <PlayerInventory> OnCandlesCollected;
    public UnityEvent <PlayerInventory> OnLighterCollected;
    public Collectables colectables;

    void Start(){
        

    }
    public void RosesCollected ()
    {
        NumberOfRoses++;
        Debug.Log("NumberofRoses: " + NumberOfRoses);
        OnRosesCollected.Invoke(this);

        if(NumberOfRoses == 6) {
            colectables.CollectSteps=1;
        }
    }
    

    public void CandlesCollected()
    {
        NumberOfCandles++;
        OnCandlesCollected.Invoke(this);
        Debug.Log("NumberofCandles: " + NumberOfCandles);

        if(NumberOfCandles == 2) {
            colectables.CollectSteps=2;
        }
    }

    public void LighterCollected()
    {
        NumberOfLighter++;
        OnLighterCollected.Invoke(this);
    }

}


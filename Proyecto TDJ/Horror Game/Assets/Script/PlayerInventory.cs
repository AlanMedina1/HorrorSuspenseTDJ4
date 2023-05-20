using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfRoses = 0; //{ get; private set; }
    
    public int NumberOfCandles=0; //{ get; private set; }
    public int NumberOfLighter=0; //{ get; private set; }
    
    // public sonidoRepentino sonidoRepentino;
    public UnityEvent <PlayerInventory> OnRosesCollected;
    public UnityEvent <PlayerInventory> OnCandlesCollected;
    public UnityEvent <PlayerInventory> OnLighterCollected;
    

    void Start(){
        //sonidoRepentino = GetComponent<sonidoRepentino>();

    }
    public void RosesCollected ()
    {
        NumberOfRoses++;
        Debug.Log("NumberofRoses: " + NumberOfRoses);
        OnRosesCollected.Invoke(this);

        /*if(NumberOfRoses== 6) {
            sonidoRepentino.playSonido();
        }*/
    }
    

    public void CandlesCollected()
    {
        NumberOfCandles++;
        OnCandlesCollected.Invoke(this);
        Debug.Log("NumberofCandles: " + NumberOfCandles);
    }

    public void LighterCollected()
    {
        NumberOfLighter++;
        OnLighterCollected.Invoke(this);
    }

}


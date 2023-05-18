using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfRoses { get; private set; }

    public void RosesCollected ()
    {
        NumberOfRoses++;
    }
}

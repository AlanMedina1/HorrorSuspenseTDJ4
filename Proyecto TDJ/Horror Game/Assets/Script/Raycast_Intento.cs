using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Intento : MonoBehaviour
{
    public float range = 8;

    void Update()
    {
        Vector3 direction = Vector3.forward;
        Ray Rayito = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

    }
}

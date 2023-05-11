using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    [SerializeField] private Transform objectDirectionObject;

    private ObjectGrabbable objectGrabbable;
   private void Update()
    {
        Physics.Raycast(transform.position, transform.forward);  // moves that object with your player's camera
        if (Input.GetMouseButtonDown(0))
        {
            if(objectGrabbable == null) 
           { 
                //no sosteniendo algo, lo agarra
            float pickUpDistance = 10f;
            if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask))
            {
                Debug.Log(raycastHit.transform);
                if (raycastHit.transform.TryGetComponent(out objectGrabbable))
                {
                    objectGrabbable.Grab(objectGrabPointTransform);
                }
                else
                {
                        Debug.Log("Dropped");
                        //si ya tiene algo, entonces lo suelta
                        objectGrabbable.Drop();
                        objectGrabbable = null;
                        
                }
            } 
         
           }

        }
    }
}

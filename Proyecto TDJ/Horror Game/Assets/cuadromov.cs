using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadromov : MonoBehaviour
{
    public GameObject cuadro1, cuadro2;
    public Collider collision;
    public AudioSource cuadroCollect;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cuadro1.SetActive(false);
            cuadro2.SetActive(true);

            cuadroCollect.Play();
            collision.enabled = false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quadaparece : MonoBehaviour
{
    // La tecla que hará desaparecer el Quad
    public KeyCode hideKey = KeyCode.H;

    // Referencia al Renderer del Quad
    private Renderer quadRenderer;

    void Start()
    {
        // Obtenemos el Renderer del objeto al que está asignado este script
        quadRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Detectamos si se presiona la tecla
        if (Input.GetKeyDown(hideKey))
        {
            // Cambiamos el estado del Renderer
            quadRenderer.enabled = !quadRenderer.enabled;
        }
    }
}
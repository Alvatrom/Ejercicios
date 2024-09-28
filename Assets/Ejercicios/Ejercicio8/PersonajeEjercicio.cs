using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeEjercicio : MonoBehaviour
{
    private string nombre;
    private int vida;
    private float experiencia;
    // Start is called before the first frame update
    void Start()
    {
        CalcularNivel(4234);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalcularNivel(int experiencia)
    {
        float nivel = experiencia / 1000;
        return nivel;
    }

}

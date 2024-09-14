using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vidaInicial = 120, turno = 0;
    float veneno = 3.6f, vida = 120f;
    // Start is called before the first frame update
    void Start()
    {
        for (int turno = 0; turno < 3; turno++)
        {
            vida -= 3.6f;
            Debug.Log("turno nº = " + turno + " Vida = "+ vida+ "/"+ vidaInicial) ;

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    
}

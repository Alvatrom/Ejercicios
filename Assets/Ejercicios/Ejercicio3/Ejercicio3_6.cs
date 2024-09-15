using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKmH = 54; 
    // Start is called before the first frame update
    void Start()
    {
        double velocidadMS = 43;//double contine entre 15 y 17 digitos
        velocidadMS = velocidadKmH / 3.6;
        Debug.Log("La velocidad por m/s = "+ velocidadMS);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

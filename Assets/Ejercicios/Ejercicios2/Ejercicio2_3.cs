using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 5, elDoble =0;
    float exp = 1.4f, elResto = 0f,elTriple = 0 ,elCociente = 0f, elProducto = 0f;
    // Start is called before the first frame update
    void Start()
    {
        elProducto = vidas * exp;
        elCociente = vidas / exp;
        elResto = vidas % exp;
        elDoble = 2 * vidas;
        elTriple = 3 * exp;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

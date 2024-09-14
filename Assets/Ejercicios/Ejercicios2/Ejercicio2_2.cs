using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 5;
    float exp = 1.4f ,resultadoResta = 0f,resultadoSuma = 0f;
    char carac ='T';
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tienes el siguiente numero de vidas "+ vidas + " y la experiencia total " + exp );
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("Tienes resultadoSuma = "+ resultadoSuma + "tu resultado resta = "+ resultadoResta);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

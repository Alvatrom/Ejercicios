using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroPorSegundo = 7,totalDeOro = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalDeOro = oroPorSegundo * 60 * 60 * 4;
        Debug.Log("Total de oro conseguido en 4 horas = "+ totalDeOro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

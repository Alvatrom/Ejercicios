using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] double cantidad = 100f;
    [SerializeField] string moneda = "Dolar";
    // Start is called before the first frame update
    void Start()
    {
        Convertir(8, "euros");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    double Convertir (double cantidad, string moneda)
    {
        if (moneda == "euros")
        {
            cantidad = cantidad + (cantidad*0.1);
            Debug.Log("Los euros introducidos son " + cantidad + "dolares");
            return cantidad;
        }
        else if (moneda =="dolares")
        {
            cantidad = cantidad - (cantidad*0.1);
            Debug.Log("Los dolares introducidos son " + cantidad + "euros");
            return cantidad;
        }
        else
        {
            Debug.Log("Es necesario escribir correctamente si son euros o dolares");
            return cantidad;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    [SerializeField] int numero = 100;
    
    void Start()
    {
        while (numero < 0)
        {
            Debug.Log("Numero " + numero);
            numero--;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

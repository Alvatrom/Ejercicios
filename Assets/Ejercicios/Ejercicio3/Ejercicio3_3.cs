using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero = 2;
    // Start is called before the first frame update
    void Start()
    {
        
        int numeroPorDos = numero * 2;
        int numeroPorTres = numero * 3;
        Debug.Log("El doble del numero es = "+ numeroPorDos+" y el triple = "+ numeroPorTres);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

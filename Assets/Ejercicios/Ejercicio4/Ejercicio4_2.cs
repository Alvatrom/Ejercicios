using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    //mirar si esta bien
    [SerializeField] string nombre = "Alvaro", apellido1 = "Gomez", apellido2 = "Exposito";
    [SerializeField] int edad = 23;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ConstruirNombre("Alvaro", "Gomez", "Exposito", 23));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        string Texto ="La persona se llama " + nombre + apellido1 + apellido2 + " y tiene " +edad;
        return Texto;

    }
}

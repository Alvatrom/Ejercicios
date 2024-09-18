using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel = 233;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    //creo que no entendi el ejercicio
    void ComprobarNiveles()
    {
        float comprobacion = 0f;
        comprobacion = nivel / 10;
        if (nivel % 10 == 0)
        {
            Debug.Log("Has aprendido un nuevo ataque");
        }

        else if (nivel/10 >=0 ) 
        {
            Debug.Log("Has aprendido un total de " + comprobacion + " niveles");

        }
        
    }
}

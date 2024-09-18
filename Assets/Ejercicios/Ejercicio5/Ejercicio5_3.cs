using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ComprobarNumero()
    {
        if (numero >=0 && numero <=9 ) 
        {
            Debug.Log("Este numero esta compredido entre el 0 y el 9");

        }
        else
        {
            Debug.Log("Este numero esta fuera del alcance de mi radar....");
           
        }
    }
}

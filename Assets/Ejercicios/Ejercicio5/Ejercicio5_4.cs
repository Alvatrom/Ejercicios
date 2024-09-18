using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int numero1 = 45, numero2 = 22;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Operacion();
    
    }
    void Operacion()
    {
        float resultado = 0;
        if(numero1 >= numero2)
        {
            resultado = numero1/numero2;
            Debug.Log("El resultado es igual a " + resultado);
        }
        else if(numero2 == 0)
        {
            Debug.Log("El resultado no se puede realizar");

        }
    }
}

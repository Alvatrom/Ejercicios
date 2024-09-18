using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel = 433;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Identificador()
    {
        if(nivel % 2 == 0)
        {
            Debug.Log("Tu nivel de personaje es un numero par");
        }
        else if (nivel % 2 != 0)
        {
            Debug.Log("Tu nivel de personaje es un numero impar");

        }
        else
        {
            Debug.Log("Viva Españaaaa");
            
        }
    }
}

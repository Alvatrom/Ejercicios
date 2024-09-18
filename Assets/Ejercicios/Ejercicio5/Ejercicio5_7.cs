using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] float velocidad1 = 30f, velocidad2 = 34f, velocidad3 = 67f;
    // Start is called before the first frame update
    void Start()
    {
        Turnos();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Turnos()
    {
        if (velocidad1 > velocidad2 && velocidad1 < velocidad3)
        {
            Debug.Log("El jugador1 ataca primero");

        }
        else if(velocidad2 >  velocidad3 && velocidad2 < velocidad1)
        {
            Debug.Log("El jugador2 ataca primero");

        }
        else
        {
            Debug.Log("El jugador3 ataca primero");

        }
    }

}

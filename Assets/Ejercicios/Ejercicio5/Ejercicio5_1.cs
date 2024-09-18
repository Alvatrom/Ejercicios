using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] float vidaJ1 = 100f, vidaJ2 = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rennido();
        
    }
    void Rennido()
    {
        if (vidaJ1== vidaJ2)
        {
            Debug.Log("La batalla esta muy reñida. ¿Quien sera el ganador?");
        }
        else
        {
            Debug.Log("Aburridoooooo");
        }
    }
}

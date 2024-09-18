using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    [SerializeField] int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (numero<100)
        {
            Debug.Log("Numero "+ numero);
            numero++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

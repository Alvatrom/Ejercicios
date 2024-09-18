using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1 = 2 , numero2 = 1 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ComprobarNumeros();
        
    }
    void ComprobarNumeros()
    {
        if(numero1 <3 && numero2 <3)
        {
            Debug.Log("Ambos numeros son menores que 3");
        }
    }
}

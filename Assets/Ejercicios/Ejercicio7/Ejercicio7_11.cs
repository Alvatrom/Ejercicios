using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero = 3;
    // Start is called before the first frame update
    void Start()
    {
        TablaMultiplicar(numero);

        
    }
    void TablaMultiplicar(int numero)
    {
        for (int i = 0; i <= 10; i++)
        {
            int solucion = numero * i;
            Debug.Log(numero + "x" + i + "=" + solucion);


        }
    }
}

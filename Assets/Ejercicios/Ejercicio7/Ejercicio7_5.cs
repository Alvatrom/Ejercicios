using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero = 34,contador = 1;
    [SerializeField] bool positivo = false;
    // Start is called before the first frame update
    void Start()
    {
        ComprobarNumero(numero);
        if (positivo == true)
        {
            while (contador < numero)
            {
                Debug.Log(contador);
                contador++;
            }
        }
        else
        { Debug.Log("Escriba un valor positivo"); }
        for (int i = 0; i < numero; i++)
        {
            Debug.Log(contador);
        }


    }
    void ComprobarNumero(int numero)
    {
        if (numero > 0)
        {
            positivo = true;
        }
        else { positivo = false; }
    }
}


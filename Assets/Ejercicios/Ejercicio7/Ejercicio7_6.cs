using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero = 100 /*numeroAdverso = -100*/;
    [SerializeField] bool positivo = false;
    // Start is called before the first frame update
    void Start()
    {
        ComprobarNumero(numero);
        //numeroAdverso = -numero;

        if (positivo == true)
        {
            while (-numero < numero)
            {
                Debug.Log(numero);
                numero--;
            }
        }
        else
        { Debug.Log("Escriba un valor positivo"); }

        for (int i = numero; i < -numero; numero--)
        {
            Debug.Log(numero);
        }


    }
    void ComprobarNumero(int numero)
    {
        if (numero > 0)
        {
            positivo = true;
        }
        else 
        { 
            positivo = false;
            Debug.Log("Escriba un valor positivo");
        }
    }

}

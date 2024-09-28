using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numero1 = 5, numero2 = 3;
    //Math.Min(valor1,valor2) para saber cual es el numero menor entra las dos variables,      Mathf.Max ////// Mathf.Min
    // Start is called before the first frame update
    void Start()
    {
        int solucion = SumarTodosLosNumeros(numero1, numero2);
        Debug.Log(solucion);

    }

    int SumarTodosLosNumeros(int numero1, int numero2)
    {
        int nmenor = Mathf.Min(numero1, numero2);
        int nmayor = Mathf.Max(numero1, numero2);
        int suma = 0;


        for (int i = nmenor; i <= nmayor; i++)
        {
            suma += i;
        }

        return suma;
    }
}

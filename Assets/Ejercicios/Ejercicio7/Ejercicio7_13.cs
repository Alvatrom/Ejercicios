using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numero = 23;
    // Start is called before the first frame update
    void Start()
    {
        bool primo = Comprobador(numero);

        if (primo)
        {
            Debug.Log(numero + " es primo");
        }
        else
        {
            Debug.Log(numero + " no es primo");

        }
        
    }
    bool Comprobador(int numero)
    {
        // numeros menores o iguales a 1 no son primos
        if(numero <=1)
        {
            return false;
        }
        // si son 2 o 3 son numeros primos siempre
        if (numero == 2 || numero == 3)
        {
            return true;
        }
        // si son numeros pares mayores que 2 no son primos
        if (numero % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= numero / 2; i += 2)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    /*Crea un método que reciba por parámetro de entrada un número entero. Este método  nos indicará si es o no un número primo. Debe devolver true si es primo sino false. 
Un número primo es aquel que solo puede dividirse entre 1 y sí mismo. Por ejemplo: 25  no es primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.*/
}
